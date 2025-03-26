using CGPFE.Data.Constants;

namespace CGPFE.World.Settlement.Properties;

public class Info {
	public readonly string Name;
	public readonly string? Nickname;
	
	public Type Type;
	public readonly Alignment Alignment;
	public int Danger;
	
	public readonly Government Government;
	public int Population;

	public Info(string name, string nickname, Type type, Alignment alignment, Government government) {
		Name = name;
		Nickname = nickname;
		Type = type;
		Alignment = alignment;
		Government = government;
		CalculatePopulationByType();
	}

	public Info(string name, string nickname, int population, Type type, Alignment alignment) {
		Name = name;
		Nickname = nickname;
		Population = population;
		Type = type;
		Alignment = alignment;
		CalculateTypeByPopulation();
	}
	
	public Info(string name, Type type, Alignment alignment, Government government) {
		Name = name;
		Type = type;
		Alignment = alignment;
		Government = government;
		CalculatePopulationByType();
	}

	public Info(string name, int population, Type type, Alignment alignment) {
		Name = name;
		Population = population;
		Type = type;
		Alignment = alignment;
		CalculateTypeByPopulation();
	}

	private void CalculatePopulationByType() {
		switch (Type) {
			case Type.Thorpe:
				Population = 15;
			break;
			case Type.Hamlet:
				Population = 40;
			break;
			case Type.Village:
				Population = 130;
			break;
			case Type.SmallTown:
				Population = 1100;
			break;
			case Type.LargeTown:
				Population = 3500;
			break;
			case Type.SmallCity:
				Population = 7500;
			break;
			case Type.LargeCity:
				Population = 17500;		
			break;
			case Type.Metropolis:
				Population = 30000;
			break;
		}
	}

	private void CalculateTypeByPopulation() {
		if(Population <= 20)
			Type = Type.Thorpe;
		else if (Population is > 20 and <= 60)
			Type = Type.Hamlet;
		else if(Population is > 60 and <= 200)
			Type = Type.Village;
		else if(Population is > 200 and <= 2000)
			Type = Type.SmallTown;
		else if (Population is > 2000 and <= 5000)
			Type = Type.LargeTown;
		else if(Population is > 5000 and <= 10000)
			Type = Type.SmallCity;
		else if(Population is > 10000 and <= 25000)
			Type = Type.LargeCity;
		else if (Population > 25000)
			Type = Type.Metropolis;
	}
}