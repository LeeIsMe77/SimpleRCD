namespace RCD.Core.Common {

	#region Directives
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	#endregion

	public class ClassSkillCollection
		: ObservableCollection<ClassSkill> {

		/// <summary>
		/// Adds a range of skills to the collection.
		/// </summary>
		/// <param name="skills">The skills.</param>
		public void AddRange(IEnumerable<ClassSkill> skills) {
			foreach (var skill in skills) {
				this.Add(skill);
			}
		}

	}

}
