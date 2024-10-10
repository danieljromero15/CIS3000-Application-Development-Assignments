import os
import shutil

if __name__ == '__main__':
    print('\nWARNING: For this utility to work correctly, the name of the folder must have a hyphen (-) in it')
    print("All folders starting with a period (such as .git) are excluded by default\n")

    print("REMEMBER TO ADD THE HEADER BEFORE SUBMITTING. Example is in the README.\n")

    print("Override zip name can be added by putting zip_name.txt inside the folder with the name you want.\n")

    cwd = os.getcwd()
    folder_names_all = [] # all folders unfiltered
    folder_names = [] # only folders
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

    # creates zip_name, removes Assignment from folder name and any spaces, and adds -RomeroD
    # this is hardcoded rn but uhh I'm the only one using it? and it's only for this, so I don't care, if you want to make changes learn python
    zip_name = folder_name.split(" - ")[-1].replace(" ", "") + "-RomeroD"

    print(folder_name, 'will be zipped as', zip_name + ".zip")

    if os.path.exists(zip_name):
        print(f'\nFolder {zip_name} already exists! Please delete folder or rename to proceed\n')
        exit(400)

    # makes temp folder without the IDE metadata to zip
    os.mkdir(zip_name)
    zip_dst_name = ""
    for file in os.listdir(folder_name):
        src_path = os.path.join(folder_name, file)
        dst_path = os.path.join(zip_name, file)
        if os.path.isdir(src_path) and not file.startswith('.'):
            shutil.copytree(src_path, dst_path, dirs_exist_ok=True)
        elif os.path.isfile(src_path):
            # before copying to temp folder, check if zip_name.txt exists and change zip_dst_name to string within
            if src_path.split("\\")[-1] == "zip_name.txt":
                # reads text file here
                f = open(src_path, "r", encoding='utf-8')
                zip_dst_name = f.read()
                print(f"zip_name.txt found! Renaming zip to {zip_dst_name}.zip")

            shutil.copyfile(src_path, dst_path)

    # if zip_dst_name is empty, replace it with the normal zip name. Otherwise, we can use the replacement name
    if zip_dst_name == "":
        zip_dst_name = zip_name
    else:
        # removes zip_name.txt from final zip
        os.remove(os.path.join(zip_name, "zip_name.txt"))

    shutil.make_archive(f'{zip_dst_name}', 'zip', f'{zip_name}')

    shutil.rmtree(zip_name)