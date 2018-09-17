using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace playground.ViewModels
{
    public class DesignMainViewModel
    {
        public IList<String> StringItems => new List<String>
        {
            "Larry", "Moe", "Curly"
        };

        public List<ItemGrouping> GroupedItems =>
        new List<ItemGrouping>
        {
            new ItemGrouping 
            {
                Group = "Group 1", 
                Items = new List<TestItemViewModel>
                {
                    new TestItemViewModel {
                        BackgroundColor = Color.Blue,
                        PrimaryText = "Primary 1",
                        SecondaryText = "Secondary 1"
                    },
                    new TestItemViewModel {
                        BackgroundColor = Color.Green,
                        PrimaryText = "Primary 2",
                        SecondaryText = "Secondary 2"
                    },
                    new TestItemViewModel {
                        BackgroundColor = Color.Red,
                        PrimaryText = "Primary 3",
                        SecondaryText = "Secondary 3"
                    },
                    new TestItemViewModel {
                        BackgroundColor = Color.Chartreuse,
                        PrimaryText = "Primary 4",
                        SecondaryText = "Secondary 4"
                    },
                    new TestItemViewModel {
                        BackgroundColor = Color.Black,
                        PrimaryText = "Primary 5",
                        SecondaryText = "Secondary 5"
                    },
                    new TestItemViewModel {
                        BackgroundColor = Color.Violet,
                        PrimaryText = "Primary 6",
                        SecondaryText = "Secondary 6"
                    }
                }
            },
            new ItemGrouping
            {
                Group = "Group 2", 
                Items = new List<TestItemViewModel>
                {
                    new TestItemViewModel {
                        BackgroundColor = Color.Blue,
                        PrimaryText = "Primary 1",
                        SecondaryText = "Secondary 1"
                    },
                    new TestItemViewModel {
                        BackgroundColor = Color.Green,
                        PrimaryText = "Primary 2",
                        SecondaryText = "Secondary 2"
                    },
                    new TestItemViewModel {
                        BackgroundColor = Color.Red,
                        PrimaryText = "Primary 3",
                        SecondaryText = "Secondary 3"
                    },
                    new TestItemViewModel {
                        BackgroundColor = Color.Chartreuse,
                        PrimaryText = "Primary 4",
                        SecondaryText = "Secondary 4"
                    },
                    new TestItemViewModel {
                        BackgroundColor = Color.Black,
                        PrimaryText = "Primary 5",
                        SecondaryText = "Secondary 5"
                    },
                    new TestItemViewModel {
                        BackgroundColor = Color.Violet,
                        PrimaryText = "Primary 6",
                        SecondaryText = "Secondary 6"
                    }
                }
            },
            new ItemGrouping
            {
                Group = "Group 3", 
                Items = new List<TestItemViewModel>
                {
                    new TestItemViewModel {
                        BackgroundColor = Color.Blue,
                        PrimaryText = "Primary 1",
                        SecondaryText = "Secondary 1"
                    },
                    new TestItemViewModel {
                        BackgroundColor = Color.Green,
                        PrimaryText = "Primary 2",
                        SecondaryText = "Secondary 2"
                    },
                    new TestItemViewModel {
                        BackgroundColor = Color.Red,
                        PrimaryText = "Primary 3",
                        SecondaryText = "Secondary 3"
                    },
                    new TestItemViewModel {
                        BackgroundColor = Color.Chartreuse,
                        PrimaryText = "Primary 4",
                        SecondaryText = "Secondary 4"
                    },
                    new TestItemViewModel {
                        BackgroundColor = Color.Black,
                        PrimaryText = "Primary 5",
                        SecondaryText = "Secondary 5"
                    },
                    new TestItemViewModel {
                        BackgroundColor = Color.Violet,
                        PrimaryText = "Primary 6",
                        SecondaryText = "Secondary 6"
                    }
                }
            }
        };
    }

    public class ItemGrouping {
        public string Group { get; set; }
        public List<TestItemViewModel> Items { get; set; } = new List<TestItemViewModel>();
    }

    public class TestItemViewModel 
    {
        public Color BackgroundColor { get; set; }

        public string PrimaryText { get; set; }

        public string SecondaryText { get; set; }
    }
}
