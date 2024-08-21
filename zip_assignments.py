import os
import shutil

if __name__ == '__main__':
    print('\nWARNING: For this utility to work correctly, the name of the folder must have a hyphen (-) in it\n')

    print("REMEMBER TO ADD THE HEADER BEFORE SUBMITTING. Example is in the README.\n")

    cwd = os.getcwd()
    folder_names = []
    for entry_name in os.listdir(cwd):
        entry_path = os.path.join(cwd, entry_name)
        if os.path.isdir(entry_path):
            folder_names.append(entry_name)

    folder_names.remove('.git')
    folder_names.remove('.idea')

    for i in range(len(folder_names)):
        print(f'{i + 1}. {folder_names[i]}')

    print()
    folder_num = int(input('Enter folder to zip: '))
    folder_name = folder_names[folder_num - 1]
    zip_name = folder_name.split(" - ")[-1].replace(" ", "") + "-RomeroD"

    print(folder_name, 'will be zipped as', zip_name + ".zip")
    shutil.make_archive(f'{zip_name}', 'zip', f'{cwd}\\{folder_name}')