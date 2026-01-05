# 📂 ASP.NET Core MVC - File Manager

Ce projet est une application web développée en **ASP.NET Core MVC** (.NET 8). Il s'agit d'un gestionnaire de documents permettant de lister, filtrer et uploader des fichiers sur le serveur.

Réalisé dans le cadre du cursus Ingénieur 3iL, ce projet met en pratique les concepts fondamentaux du pattern Modèle-Vue-Contrôleur.


## 🛠️ Concepts Clés Abordés

* **Architecture MVC :** Séparation des responsabilités (Models, Views, Controllers).
* **Routing Dynamique :** Utilisation de routes avec paramètres optionnels pour le filtrage (`/Documents/Liste/{extension}/{nom}`).
* **System.IO :** Manipulation du système de fichiers serveur (Lecture de répertoires, Upload).
* **Razor & Helpers :** Utilisation de syntaxe Razor (`@foreach`, `@Html.BeginForm`) pour générer le HTML.
* **Transfert de données :** Utilisation de `ViewData` et `ViewBag`.

## 🚀 Fonctionnalités

### 1. Listing des documents
L'application scanne le dossier serveur `wwwroot/Files` et affiche les métadonnées :
* Nom du fichier
* Taille (octets)
* Lien de téléchargement/visualisation

### 2. Système de Filtrage
Le filtrage se fait sans rechargement de base de données, via l'URL :
* **Par extension :** `/Documents/Liste/pdf`
* **Par nom :** `/Documents/Liste/pdf/cours`
* **Interface :** Une liste déroulante (JS) et une TextBox permettent de générer ces URLs dynamiquement.

### 3. Upload de Fichiers
Un module dédié permet d'envoyer des fichiers vers le serveur (dossier `wwwroot/uploads`) avec validation côté serveur.

## ⚙️ Installation et Test

1.  **Cloner le dépôt :**
    ```bash
    git clone [https://github.com/maximilien00/MVC-File-Manager](https://github.com/maximilien00/MVC-File-Manager)
    ```
2.  **Préparer les dossiers :**
    Assurez-vous que les dossiers suivants existent à la racine du projet Web :
    * `wwwroot/Files` (Mettez-y quelques PDF pour tester)
    * `wwwroot/uploads`
3.  **Lancer l'application :**
    ```bash
    dotnet run
    ```
4.  **Accéder au site :**
    Ouvrez votre navigateur sur `https://localhost:xxxx` (port indiqué dans la console).

---
*Projet réalisé dans le cadre du module Développement .Net (2024/2025). - 3iL Ingenieurs*
