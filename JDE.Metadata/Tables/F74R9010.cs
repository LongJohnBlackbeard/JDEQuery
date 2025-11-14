using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74R9010 - .
/// </summary>
public class F74R9010 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PLR74REPN.
        /// </summary>
        public const string PLR74REPN = "PLR74REPN";

        /// <summary>
        /// PLR74SECT.
        /// </summary>
        public const string PLR74SECT = "PLR74SECT";

        /// <summary>
        /// PLR74RROW.
        /// </summary>
        public const string PLR74RROW = "PLR74RROW";

        /// <summary>
        /// PLD240.
        /// </summary>
        public const string PLD240 = "PLD240";

        /// <summary>
        /// PLR74CODE.
        /// </summary>
        public const string PLR74CODE = "PLR74CODE";

        /// <summary>
        /// PLAA.
        /// </summary>
        public const string PLAA = "PLAA";

        /// <summary>
        /// PLAA1.
        /// </summary>
        public const string PLAA1 = "PLAA1";

        /// <summary>
        /// PLAA2.
        /// </summary>
        public const string PLAA2 = "PLAA2";

        /// <summary>
        /// PLAA3.
        /// </summary>
        public const string PLAA3 = "PLAA3";

        /// <summary>
        /// PLURAB.
        /// </summary>
        public const string PLURAB = "PLURAB";

        /// <summary>
        /// PLURAT.
        /// </summary>
        public const string PLURAT = "PLURAT";

        /// <summary>
        /// PLURDT.
        /// </summary>
        public const string PLURDT = "PLURDT";

        /// <summary>
        /// PLURCD.
        /// </summary>
        public const string PLURCD = "PLURCD";

        /// <summary>
        /// PLURRF.
        /// </summary>
        public const string PLURRF = "PLURRF";

        /// <summary>
        /// PLUSER.
        /// </summary>
        public const string PLUSER = "PLUSER";

        /// <summary>
        /// PLPID.
        /// </summary>
        public const string PLPID = "PLPID";

        /// <summary>
        /// PLJOBN.
        /// </summary>
        public const string PLJOBN = "PLJOBN";

        /// <summary>
        /// PLUPMJ.
        /// </summary>
        public const string PLUPMJ = "PLUPMJ";

        /// <summary>
        /// PLUPMT.
        /// </summary>
        public const string PLUPMT = "PLUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F74R9010";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PLR74REPN", "PLR74REPN", JdeDataType.String, 40, true, true),
        new JdeField("PLR74SECT", "PLR74SECT", JdeDataType.String, 4, true, true),
        new JdeField("PLR74RROW", "PLR74RROW", JdeDataType.String, 8, true, true),
        new JdeField("PLD240", "PLD240", JdeDataType.String, 480),
        new JdeField("PLR74CODE", "PLR74CODE", JdeDataType.String, 8),
        new JdeField("PLAA", "PLAA", JdeDataType.Numeric),
        new JdeField("PLAA1", "PLAA1", JdeDataType.Numeric),
        new JdeField("PLAA2", "PLAA2", JdeDataType.Numeric),
        new JdeField("PLAA3", "PLAA3", JdeDataType.Numeric),
        new JdeField("PLURAB", "PLURAB", JdeDataType.Numeric),
        new JdeField("PLURAT", "PLURAT", JdeDataType.Numeric),
        new JdeField("PLURDT", "PLURDT", JdeDataType.Numeric),
        new JdeField("PLURCD", "PLURCD", JdeDataType.String, 4),
        new JdeField("PLURRF", "PLURRF", JdeDataType.String, 30),
        new JdeField("PLUSER", "PLUSER", JdeDataType.String, 20),
        new JdeField("PLPID", "PLPID", JdeDataType.String, 20),
        new JdeField("PLJOBN", "PLJOBN", JdeDataType.String, 20),
        new JdeField("PLUPMJ", "PLUPMJ", JdeDataType.Numeric),
        new JdeField("PLUPMT", "PLUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74R9010_0", "Primary Key on PLR74REPN, PLR74SECT, PLR74RROW", new[] { "PLR74REPN", "PLR74SECT", "PLR74RROW" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F74R9010_2", "Index on PLR74CODE", new[] { "PLR74CODE" })
    };
}
