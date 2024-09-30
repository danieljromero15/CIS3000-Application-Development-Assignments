import os
import shutil

if __name__ == '__main__':
    print('\nWARNING: For this utility to work correctly, the name of the folder must have a hyphen (-) in it')
    print("All folders starting with a period (such as .git) are excluded by default\n")

    print("REMEMBER TO ADD THE HEADER BEFORE SUBMITTING. Example is in the README.\n")

    cwd = os.getcwd()
    folder_names_all = []
    folder_names = []
    for entry_name in os.listdir(cwd):
        entry_path = os.path.join(cwd, entry_name)
        if os.path.isdir(entry_path):
            folder_names_all.append(entry_name)

    for folder_name in folder_names_all:
        if not folder_name.startswith('.'):
            folder_names.append(folder_name)

    for i in range(len(folder_names)):
        print(f'{i + 1}. {folder_names[i]}')

    print()
    folder_num = int(input('Enter folder to zip: '))
    folder_name = folder_names[folder_num - 1]
    zip_name = folder_name.split(" - ")[-1].replace(" ", "") + "-RomeroD"

    print(folder_name, 'will be zipped as', zip_name + ".zip")

    if os.path.exists(zip_name):
        print(f'\nFolder {zip_name} already exists! Please delete folder or rename to proceed\n')
        exit(400)

    # makes temp folder without the IDE metadata to zip
    os.mkdir(zip_name)
    for file in os.listdir(folder_name):
        src_path = os.path.join(folder_name, file)
        dst_path = os.path.join(zip_name, file)
        if os.path.isdir(src_path) and not file.startswith('.'):
            shutil.copytree(src_path, dst_path, dirs_exist_ok=True)
        elif os.path.isfile(src_path):
            shutil.copyfile(src_path, dst_path)

    shutil.make_archive(f'{zip_name}', 'zip', f'{zip_name}')

    shutil.rmtree(zip_name)