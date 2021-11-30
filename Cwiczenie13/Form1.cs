﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cwiczenie13
{
    public partial class Form1 : Form
    {
            int Moves;
            Location currentLocation;

            RoomWithDoor livingRoom;
            RoomWithHidingPlace diningRoom;
            RoomWithDoor kitchen;
        Room stairs;
        RoomWithHidingPlace hallway;
        RoomWithHidingPlace bathroom;
        RoomWithHidingPlace masterBedroom;
        RoomWithHidingPlace secondBedroom;

            OutsideWithDoor frontYard;
            OutsideWithDoor backYard;
            OutsideWithHidingPlace garden;
        OutsideWithHidingPlace driveway;
        Opponent opponent;
        public Form1()
        {
            InitializeComponent();
            CreateObjects();
            opponent = new Opponent(frontYard);
            ResetGame(false);
        } 
        private void ResetGame(bool displayMessage)
        {
            if (displayMessage)
            {
                MessageBox.Show("Odnalazłeś mnie w " + Moves + "ruchach!");
                IHidingPlace foundLocation = currentLocation as IHidingPlace;
                description.Text = "Znalazłeś przeciwnika w " + Moves + " ruchach! Ukrywał się " + foundLocation.HidingPlaceName + ".";
            }
            Moves = 0;
            hide.Visible = true;
            goHere.Visible = false;
            check.Visible = false;
            goThroughTheDoor.Visible = false;
            exits.Visible = false;
        }
        private void MoveToANewLocation(Location newLocation)
        {
            Moves++;
            currentLocation = newLocation;
            RedrawForm();
            
        }

        private void RedrawForm()
        {
            exits.Items.Clear();
            for (int i = 0; i < currentLocation.Exits.Length; i++)
                exits.Items.Add(currentLocation.Exits[i].Name);
            exits.SelectedIndex = 0;
            description.Text = currentLocation.Description + "\r\n(ruch numer " + Moves + ")";
            if (currentLocation is IHidingPlace)
            {
                IHidingPlace hidingPlace = currentLocation as IHidingPlace;
                check.Text = "Sprawdź " + hidingPlace.HidingPlaceName;
                check.Visible = true;
            }
            else
                check.Visible = false;
            if(currentLocation is IHasExteriorDoor)
                goThroughTheDoor.Visible = true;
            else
                goThroughTheDoor.Visible = false;
        }
        private void CreateObjects()
        {
            livingRoom = new RoomWithDoor("Salon", "antyczny dywan", "w szafie ściennej", "dębowe drzwi z mosiężną klamką");
            diningRoom = new RoomWithHidingPlace("Jadalnia", "kryształowy żyrandol", "w wysokiej szafie");
            kitchen = new RoomWithDoor("Kuchnia", "nierdzewne stalowe sztućce", "w szafce", "rozsuwane drzwi");
            stairs = new Room("Schody", "drewniana poręcz");
            hallway = new RoomWithHidingPlace("Korytarz na górze", "Obrazek z psem", "W szafie ścienniej");
            bathroom = new RoomWithHidingPlace("Łazienka", "umywalka i toaleta", "pod prysznicem");
            masterBedroom = new RoomWithHidingPlace("Duża sypialnia", "duże łózko", "pod łóżkiem");
            secondBedroom = new RoomWithHidingPlace("Druga sypialnia", "małe łózko", "pod łóżkiem");

            frontYard = new OutsideWithDoor("Podwórko przed domem", false, "dębowe drzwi z mosiężną klamką");
            backYard = new OutsideWithDoor("Podwórko za domem", true, "rozsuwane drzwi");
            garden = new OutsideWithHidingPlace("Ogród", false, "w szopie");
            driveway = new OutsideWithHidingPlace("Droga dojazdowa", true, "w garażu");

            diningRoom.Exits = new Location[] {livingRoom, kitchen};
            livingRoom.Exits = new Location[] {diningRoom, stairs};
            kitchen.Exits = new Location[] { diningRoom };
            stairs.Exits = new Location[] {livingRoom, hallway };
            hallway.Exits = new Location[] {stairs, bathroom, masterBedroom, secondBedroom};
            bathroom.Exits = new Location[] {hallway};
            masterBedroom.Exits = new Location[] {hallway };
            secondBedroom.Exits = new Location[] {hallway };
            frontYard.Exits = new Location[] {backYard, garden };
            backYard.Exits = new Location[] {frontYard, garden};
            garden.Exits = new Location[] { backYard, frontYard };
            driveway.Exits = new Location[] {backYard,frontYard};

            livingRoom.DoorLocation = frontYard;
            frontYard.DoorLocation = livingRoom;

            kitchen.DoorLocation = backYard;
            backYard.DoorLocation = kitchen;
        }


        interface IHidingPlace
        {
            string HidingPlaceName { get; }
        }
        class RoomWithHidingPlace : Room, IHidingPlace
        {
            public RoomWithHidingPlace(string name, string decoration, string hidingPlaceName)
                : base(name, decoration)
            {
                HidingPlaceName = hidingPlaceName;
            }
            public string HidingPlaceName { get; private set; }
            public override string Description
            {
                get
                {
                    return base.Description + " Ktoś może ukrywać się " + HidingPlaceName + ".";
                }
            }
        }

        class RoomWithDoor : RoomWithHidingPlace, IHasExteriorDoor
        {
            public RoomWithDoor(string name, string decoration, string hidingPlaceName, string doorDescription)
                : base(name, decoration, hidingPlaceName)
            {
                DoorDescription = doorDescription;
            }
            public string DoorDescription { get; private set; }
            public Location DoorLocation { get; set; }
        }

        class OutsideWithHidingPlace : Outside, IHidingPlace
        {
            public OutsideWithHidingPlace(string name, bool hot, string hidingPlaceName)
                : base(name, hot)
            {
                HidingPlaceName = hidingPlaceName;
            }
            public string HidingPlaceName { get; private set; }
            public override string Description
            {
                get
                {
                    return base.Description + " Ktoś może ukrywać się " + HidingPlaceName + ".";
                }
            }
        }

        class Opponent
        {
            private Random random;
            private Location myLocation;
            public Opponent(Location startingLocation)
            {
                myLocation = startingLocation;
                random = new Random();
            }
            public void Move()
            {
                bool hidden = false;
                while (!hidden)
                {
                    if (myLocation is IHasExteriorDoor)
                    {
                        IHasExteriorDoor locationWithDoor = myLocation as IHasExteriorDoor;
                        if (random.Next(2) == 1)
                            myLocation = locationWithDoor.DoorLocation;
                    }
                    int rand = random.Next(myLocation.Exits.Length);
                    myLocation = myLocation.Exits[rand];
                    if (myLocation is IHidingPlace)
                        hidden = true;
                }
            }
            public bool Check(Location locationToCheck)
            {
                if (locationToCheck != myLocation)
                    return false;
                else
                    return true;
            }
        }
        private void goThroughTheDoor_Click(object sender, EventArgs e)
        {
            IHasExteriorDoor hasDoor = currentLocation as IHasExteriorDoor;
            MoveToANewLocation(hasDoor.DoorLocation);
        }

        private void goHere_Click(object sender, EventArgs e)
        {
            MoveToANewLocation(currentLocation.Exits[exits.SelectedIndex]);
        }

        private void check_Click(object sender, EventArgs e)
        {
            Moves++;
            if (opponent.Check(currentLocation))
                ResetGame(true);
            else
                RedrawForm();
        }

        private void hide_Click(object sender, EventArgs e)
        {
            hide.Visible = false;
            for (int i = 1; i <= 10; i++)
            {
                opponent.Move();
                description.Text = i + "... ";
                Application.DoEvents();
                System.Threading.Thread.Sleep(200);
            }
            description.Text = "Gotowy czy nie - nadchodzę!";
            Application.DoEvents();
            System.Threading.Thread.Sleep(500);

            goHere.Visible = true;
            exits.Visible = true;
            MoveToANewLocation(livingRoom);
        }
    }
}
