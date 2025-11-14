using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F40203 - .
/// </summary>
public class F40203 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// FSDCTO.
        /// </summary>
        public const string FSDCTO = "FSDCTO";

        /// <summary>
        /// FSTRTY.
        /// </summary>
        public const string FSTRTY = "FSTRTY";

        /// <summary>
        /// FSSTDS.
        /// </summary>
        public const string FSSTDS = "FSSTDS";

        /// <summary>
        /// FSLNTY.
        /// </summary>
        public const string FSLNTY = "FSLNTY";

        /// <summary>
        /// FSLNDS.
        /// </summary>
        public const string FSLNDS = "FSLNDS";

        /// <summary>
        /// FSLND2.
        /// </summary>
        public const string FSLND2 = "FSLND2";

        /// <summary>
        /// FSNXTR.
        /// </summary>
        public const string FSNXTR = "FSNXTR";

        /// <summary>
        /// FSA1TR.
        /// </summary>
        public const string FSA1TR = "FSA1TR";

        /// <summary>
        /// FSA2TR.
        /// </summary>
        public const string FSA2TR = "FSA2TR";

        /// <summary>
        /// FSA3TR.
        /// </summary>
        public const string FSA3TR = "FSA3TR";

        /// <summary>
        /// FSA4TR.
        /// </summary>
        public const string FSA4TR = "FSA4TR";

        /// <summary>
        /// FSA5TR.
        /// </summary>
        public const string FSA5TR = "FSA5TR";

        /// <summary>
        /// FSFID.
        /// </summary>
        public const string FSFID = "FSFID";

        /// <summary>
        /// FSORNN.
        /// </summary>
        public const string FSORNN = "FSORNN";

        /// <summary>
        /// FSWRTH.
        /// </summary>
        public const string FSWRTH = "FSWRTH";
    }

    /// <inheritdoc />
    public override string TableName => "F40203";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("FSDCTO", "FSDCTO", JdeDataType.String, 4, true, true),
        new JdeField("FSTRTY", "FSTRTY", JdeDataType.String, 6, true, true),
        new JdeField("FSSTDS", "FSSTDS", JdeDataType.String, 60),
        new JdeField("FSLNTY", "FSLNTY", JdeDataType.String, 4, true, true),
        new JdeField("FSLNDS", "FSLNDS", JdeDataType.String, 60),
        new JdeField("FSLND2", "FSLND2", JdeDataType.String, 60),
        new JdeField("FSNXTR", "FSNXTR", JdeDataType.String, 6),
        new JdeField("FSA1TR", "FSA1TR", JdeDataType.String, 6),
        new JdeField("FSA2TR", "FSA2TR", JdeDataType.String, 6),
        new JdeField("FSA3TR", "FSA3TR", JdeDataType.String, 6),
        new JdeField("FSA4TR", "FSA4TR", JdeDataType.String, 6),
        new JdeField("FSA5TR", "FSA5TR", JdeDataType.String, 6),
        new JdeField("FSFID", "FSFID", JdeDataType.String, 20),
        new JdeField("FSORNN", "FSORNN", JdeDataType.Numeric),
        new JdeField("FSWRTH", "FSWRTH", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F40203_0", "Primary Key on FSDCTO, FSLNTY, FSTRTY", new[] { "FSDCTO", "FSLNTY", "FSTRTY" }, isUnique: true, isPrimaryKey: true)
    };
}
