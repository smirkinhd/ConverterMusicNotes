import os
from spleeter.separator import Separator
import argparse

def split_audio(input_file, output_dir):
    separator = Separator('spleeter:5stems')
    print(f"Начинается разделение файла: {input_file}")
    separator.separate_to_file(input_file, output_dir)
    print(f"Результаты сохранены в директории: {output_dir}")

if __name__ == "__main__":
    parser = argparse.ArgumentParser(description="Разделение аудиофайла с помощью Spleeter.")
    parser.add_argument('-i', '--input', type=str, required=True, help="Путь к входному аудиофайлу")
    parser.add_argument('-o', '--output', type=str, required=True, help="Путь к выходной директории")
    
    args = parser.parse_args()
    
    input_audio = args.input
    output_directory = args.output
    
    os.makedirs(output_directory, exist_ok=True)
    
    split_audio(input_audio, output_directory)
