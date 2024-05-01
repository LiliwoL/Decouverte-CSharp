# Découverte C#

[toc]

v0.1

---
<div style="page-break-after: always;"></div>

On souhaite découvrir le fonctionnement de Visual Studio C#.

https://github.com/LiliwoL/Decouverte-CSharp

## Démarrage du projet

Nous allons découvrir comment réaliser une application graphique simple en utilisant Visual Studio 2022.

Au lancement de Visual Studio 2022, créez un nouveau projet.
![dc0d4482fe53947afb361c90e9e96757.png](:/5b8ad74f6f0b410a8802d83405c1dca5)

Sélectionnez le type de projet ***Application Windows Forms (.NET Framework)**.

![9cf590749def95b67bc681f16303a0c7.png](:/c91cf52ced894ec39ee1a4893a86b4e0)

Dans l'écran suivant, remplissez les champs vous demandant:
- Nom du projet
- Emplacement du projet

---
<div style="page-break-after: always;"></div>

## Pré-requis: Découverte de l'interface

### Design

Au centre de l'application, vous voyez visuellement une interface permettant de placer visuellement les contrôles.

![55b26d4cef5202058c148f7b92358d4d.png](:/207128446bdb411399efcaf4e89cd19f)

---
<div style="page-break-after: always;"></div>

### Boite à outils

Sur la partie gauche, la **boîte à outils**, vous présente tous les **contrôles** utilisables dans Windows Form.
Les contrôles sont classés. Nous utiliserons dans les **contrôles communs**.

- Boutons
- Label
- TextBox

et dans les **contrôles de données**:

- DataGridView

---
<div style="page-break-after: always;"></div>

### Démarrer

En haut au centre, un bouton ![97b3889b35d04ed92ef80000c7cb66dc.png](:/73373a0300d048e293e71255784c91fd) apparaît (uniquement quand vous êtes dans la vue **Design** de votre fenêtre).

Si vous cliquez dessus, le programme se compile et se lance.

---
<div style="page-break-after: always;"></div>

### Explorateur de solutions

Sur la droite, l'**explorateur de solutions** va vous présenter le contenu de votre projet, les fichiers utilisés, les classes...

Le bouton ![6466e04e515d302694f6719cfe290aaa.png](:/047759935b6d4db1bb7d479471dc2840) vous permt de naviguer entre les différentes vues de cet explorateur (et ainsi voir uniquement la vue par fichiers).

### Propriétés

Enfin, en bas à droite, les **Propriétés** permettent de définir les **propriétés** des contrôles que vous avez sélectionné.
Cet onglet n'apparaît que quand vous êtes dans la vue **Design** de votre fenêtre.

---
<div style="page-break-after: always;"></div>

## Mission 1: Analyse et Conception

On souhaite réaliser une application simple pour découvrir différents contrôles.

![fb018b8f19ab9199b40c900390f174b3.png](:/2b7ddfe2539747ae805b7a4083ef9d3b)

Sur la partie **gauche**:
- Des **labels** et leur **textbox** pour saisir un **titre** et un **message**.

Sur la partie **droite**:
- Un **DatagridView** pour stocker les **titres** et **messages** saisis dans la partie de gauche.

En bas, deux **boutons**:
- Un **bouton** pour **enregistrer** le contenu des deux **textbox** dans la **datagridview**
- Un **bouton** vider le contenu de la **datagridview**

> ---
> ✍️**Travail à faire**
> - Réalisez un **diagramme d'activité** pour les événements de **clic** sur les boutons.
> - Que se passe t'il si les champs sont vides?
> - Y a t'il une confirmation demandée?
> ---

---
<div style="page-break-after: always;"></div>

## Mission 2: Design de l'interface

Appuyez vous sur le contenu présenté ci-dessus pour réaliser l'apparence de l'application.

Dans l'onglet des propriétés, pensez à renommer les contrôles.

> **Attention:** Tout contrôle qui restera nommé par défaut (exemple: button1 ou label2) sera sanctionné par un gage.

> ---
> ✍️**Travail à faire**
> - Réalisez l'IHM de l'application.
> - Nommez les contrôles correctement.
> ---

---
<div style="page-break-after: always;"></div>

## Mission 3: Développer les fonctionnalités

Pour chacun des boutons, et à partir du diagramme d'activités que vous avez réalisé, vous allez pouvoir coder le comportement.

### Bouton Sauvegarder

Double cliquez sur le bouton **Sauvegarder**.

Vous arrivez sur la vue **Code** de l'application.

Dans la **méthode** correspondant à l'événement **clic** du bouton sélectionné, vous pouvez saisir le code souhaité.

 ```
private void btnSave_Click(object sender, EventArgs e)
{
	// Création d'une nouvelle ligne de DataGridView vide
  var row = new DataGridViewRow();

  // Ajout de nouvelles cellules dans la ligne crée ci dessus
  // en utilisant le contenu des textbox Title et Message
  row.CreateCells(dgvListeMessages, txtTitle.Text, txtMessage.Text);

  // Et ajout de la ligne dans le DataGridView
  dgvListeMessages.Rows.Add(row);
}
```
### Bouton Vider

Idem pour le bouton **Vider**:
```csharp
private void btnPurge_Click(object sender, EventArgs e)
{
	// Vidage de toutes les lignes du DataGridView
	dgvListeMessages.Rows.Clear();
}
```


---
<div style="page-break-after: always;"></div>

## Mission 4: Outils de déboggage