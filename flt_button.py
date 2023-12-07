import flet as ft

def main(page):
    btn = ft.ElevatedButton("ckick me!")
    page.add(btn)

ft.app(target=main)