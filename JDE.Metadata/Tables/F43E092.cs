using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F43E092 - .
/// </summary>
public class F43E092 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// AGAEMPGP.
        /// </summary>
        public const string AGAEMPGP = "AGAEMPGP";

        /// <summary>
        /// AGMCU.
        /// </summary>
        public const string AGMCU = "AGMCU";

        /// <summary>
        /// AGYN.
        /// </summary>
        public const string AGYN = "AGYN";

        /// <summary>
        /// AGAPSD.
        /// </summary>
        public const string AGAPSD = "AGAPSD";

        /// <summary>
        /// AGALIM.
        /// </summary>
        public const string AGALIM = "AGALIM";

        /// <summary>
        /// AGRPER.
        /// </summary>
        public const string AGRPER = "AGRPER";

        /// <summary>
        /// AGOSTP.
        /// </summary>
        public const string AGOSTP = "AGOSTP";

        /// <summary>
        /// AGUSER.
        /// </summary>
        public const string AGUSER = "AGUSER";

        /// <summary>
        /// AGPID.
        /// </summary>
        public const string AGPID = "AGPID";

        /// <summary>
        /// AGJOBN.
        /// </summary>
        public const string AGJOBN = "AGJOBN";

        /// <summary>
        /// AGUPMJ.
        /// </summary>
        public const string AGUPMJ = "AGUPMJ";

        /// <summary>
        /// AGTDAY.
        /// </summary>
        public const string AGTDAY = "AGTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F43E092";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("AGAEMPGP", "AGAEMPGP", JdeDataType.String, 10, true, true),
        new JdeField("AGMCU", "AGMCU", JdeDataType.String, 24, true, true),
        new JdeField("AGYN", "AGYN", JdeDataType.String, 2),
        new JdeField("AGAPSD", "AGAPSD", JdeDataType.String, 2),
        new JdeField("AGALIM", "AGALIM", JdeDataType.Numeric),
        new JdeField("AGRPER", "AGRPER", JdeDataType.Numeric),
        new JdeField("AGOSTP", "AGOSTP", JdeDataType.String, 6),
        new JdeField("AGUSER", "AGUSER", JdeDataType.String, 20),
        new JdeField("AGPID", "AGPID", JdeDataType.String, 20),
        new JdeField("AGJOBN", "AGJOBN", JdeDataType.String, 20),
        new JdeField("AGUPMJ", "AGUPMJ", JdeDataType.Numeric),
        new JdeField("AGTDAY", "AGTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F43E092_0", "Primary Key on AGAEMPGP, AGMCU", new[] { "AGAEMPGP", "AGMCU" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F43E092_2", "Index on AGAEMPGP", new[] { "AGAEMPGP" })
    };
}
