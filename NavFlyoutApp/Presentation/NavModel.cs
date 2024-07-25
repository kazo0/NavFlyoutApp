using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavFlyoutApp.Presentation;
public partial record NavModel(INavigator Navigator)
{
	public string Title { get; init; } = "Nav Title";
}
