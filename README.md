# 🎄 Advent of Code 2024 🎄

Bienvenue dans mon dépôt **Advent of Code 2024** ! Ce projet contient mes solutions aux défis journaliers de l'[Advent of Code](https://adventofcode.com/2024), un événement annuel de programmation proposant des casse-têtes amusants et stimulants tout au long du mois de décembre.

---

## 📜 Description du projet

Chaque jour du mois de décembre, un nouveau défi est publié. Les défis sont divisés en deux parties :
- La **version standard**, qui explore des concepts de programmation.
- La **version bonus**, qui ajoute une complexité supplémentaire pour tester vos compétences.

Ce dépôt est écrit en **C#** et utilise une architecture modulaire pour gérer efficacement chaque jour et ses bonus.

---

## 🚀 Fonctionnalités

- **Exécution interactive** : Choisissez un jour et activez la version bonus si nécessaire.
- **Persistant** : Les dernières valeurs saisies (jour et choix bonus) sont sauvegardées pour simplifier les exécutions futures.

---

## 🛠️ Installation

1. Clonez ce dépôt :
   ```bash
   git clone https://github.com/Affy657/Advent_Of_Code_2024.git
   cd Advent_Of_Code_2024
	```
2. Installez le SDK .NET 8 (ou supérieur) si ce n'est pas déjà fait. Vérifiez avec :
	```bash
   dotnet --version
   ```
3. Exécutez le projet en mode console :
   ```bash
   dotnet run
   ```

	---

## 📖 Utilisation

1. **Jour à exécuter** : Entrez un numéro entre 1 et 25 (les dernières valeurs saisies sont proposées par défaut).
2. **Version bonus** : Choisissez si vous voulez exécuter la version bonus (n / y).

## ✨ Exemple de Résultat

```bash
=============================================
             - Advent of Code -      
=============================================

-> Entrez le numéro du jour (entre 1 et 25) [2] : 2
-> Voulez-vous la version bonus (n / y) [n] ? n

[INFO] Lecture du fichier : inputDay02.txt

[INFO] Exécution de l'algorithme...

[RESULTAT] Résultat de l'algorithme :

3
	
```