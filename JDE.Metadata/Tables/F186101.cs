using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F186101 - .
/// </summary>
public class F186101 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// FDLRSFID.
        /// </summary>
        public const string FDLRSFID = "FDLRSFID";

        /// <summary>
        /// FDLRSFUC.
        /// </summary>
        public const string FDLRSFUC = "FDLRSFUC";

        /// <summary>
        /// FDLRSFT.
        /// </summary>
        public const string FDLRSFT = "FDLRSFT";

        /// <summary>
        /// FDLRSTN.
        /// </summary>
        public const string FDLRSTN = "FDLRSTN";

        /// <summary>
        /// FDDTAI.
        /// </summary>
        public const string FDDTAI = "FDDTAI";

        /// <summary>
        /// FDOWDI.
        /// </summary>
        public const string FDOWDI = "FDOWDI";

        /// <summary>
        /// FDLRSSM.
        /// </summary>
        public const string FDLRSSM = "FDLRSSM";

        /// <summary>
        /// FDFCTNM.
        /// </summary>
        public const string FDFCTNM = "FDFCTNM";

        /// <summary>
        /// FDLRSFFAI.
        /// </summary>
        public const string FDLRSFFAI = "FDLRSFFAI";

        /// <summary>
        /// FDUSER.
        /// </summary>
        public const string FDUSER = "FDUSER";

        /// <summary>
        /// FDPID.
        /// </summary>
        public const string FDPID = "FDPID";

        /// <summary>
        /// FDJOBN.
        /// </summary>
        public const string FDJOBN = "FDJOBN";

        /// <summary>
        /// FDUPMJ.
        /// </summary>
        public const string FDUPMJ = "FDUPMJ";

        /// <summary>
        /// FDTDAY.
        /// </summary>
        public const string FDTDAY = "FDTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F186101";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("FDLRSFID", "FDLRSFID", JdeDataType.Numeric, null, true, true),
        new JdeField("FDLRSFUC", "FDLRSFUC", JdeDataType.String, 10),
        new JdeField("FDLRSFT", "FDLRSFT", JdeDataType.String, 2),
        new JdeField("FDLRSTN", "FDLRSTN", JdeDataType.String, 20),
        new JdeField("FDDTAI", "FDDTAI", JdeDataType.String, 20),
        new JdeField("FDOWDI", "FDOWDI", JdeDataType.String, 80),
        new JdeField("FDLRSSM", "FDLRSSM", JdeDataType.String, 20),
        new JdeField("FDFCTNM", "FDFCTNM", JdeDataType.String, 64),
        new JdeField("FDLRSFFAI", "FDLRSFFAI", JdeDataType.String, 2),
        new JdeField("FDUSER", "FDUSER", JdeDataType.String, 20),
        new JdeField("FDPID", "FDPID", JdeDataType.String, 20),
        new JdeField("FDJOBN", "FDJOBN", JdeDataType.String, 20),
        new JdeField("FDUPMJ", "FDUPMJ", JdeDataType.Numeric),
        new JdeField("FDTDAY", "FDTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F186101_0", "Primary Key on FDLRSFID", new[] { "FDLRSFID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F186101_2", "Index on FDLRSFUC, FDLRSTN, FDDTAI", new[] { "FDLRSFUC", "FDLRSTN", "FDDTAI" }),
        new JdeIndex("F186101_5", "Index on FDLRSFUC, FDLRSTN, FDOWDI", new[] { "FDLRSFUC", "FDLRSTN", "FDOWDI" }),
        new JdeIndex("F186101_6", "Index on FDFCTNM", new[] { "FDFCTNM" })
    };
}
