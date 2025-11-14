using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1713 - .
/// </summary>
public class F1713 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// EENUMB.
        /// </summary>
        public const string EENUMB = "EENUMB";

        /// <summary>
        /// EEDOCO.
        /// </summary>
        public const string EEDOCO = "EEDOCO";

        /// <summary>
        /// EEDCTO.
        /// </summary>
        public const string EEDCTO = "EEDCTO";

        /// <summary>
        /// EEOORN.
        /// </summary>
        public const string EEOORN = "EEOORN";

        /// <summary>
        /// EEOCTO.
        /// </summary>
        public const string EEOCTO = "EEOCTO";

        /// <summary>
        /// EEITM.
        /// </summary>
        public const string EEITM = "EEITM";

        /// <summary>
        /// EEMMCU.
        /// </summary>
        public const string EEMMCU = "EEMMCU";

        /// <summary>
        /// EEREMK.
        /// </summary>
        public const string EEREMK = "EEREMK";

        /// <summary>
        /// EEDSE.
        /// </summary>
        public const string EEDSE = "EEDSE";

        /// <summary>
        /// EEBEGT.
        /// </summary>
        public const string EEBEGT = "EEBEGT";

        /// <summary>
        /// EEATFN.
        /// </summary>
        public const string EEATFN = "EEATFN";

        /// <summary>
        /// EETMCO.
        /// </summary>
        public const string EETMCO = "EETMCO";

        /// <summary>
        /// EEURDT.
        /// </summary>
        public const string EEURDT = "EEURDT";

        /// <summary>
        /// EEURCD.
        /// </summary>
        public const string EEURCD = "EEURCD";

        /// <summary>
        /// EEURAB.
        /// </summary>
        public const string EEURAB = "EEURAB";

        /// <summary>
        /// EEURAT.
        /// </summary>
        public const string EEURAT = "EEURAT";

        /// <summary>
        /// EEURRF.
        /// </summary>
        public const string EEURRF = "EEURRF";

        /// <summary>
        /// EEUSER.
        /// </summary>
        public const string EEUSER = "EEUSER";

        /// <summary>
        /// EEPID.
        /// </summary>
        public const string EEPID = "EEPID";

        /// <summary>
        /// EEJOBN.
        /// </summary>
        public const string EEJOBN = "EEJOBN";

        /// <summary>
        /// EEUPMJ.
        /// </summary>
        public const string EEUPMJ = "EEUPMJ";

        /// <summary>
        /// EEUPMT.
        /// </summary>
        public const string EEUPMT = "EEUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F1713";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("EENUMB", "EENUMB", JdeDataType.Numeric, null, true, true),
        new JdeField("EEDOCO", "EEDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("EEDCTO", "EEDCTO", JdeDataType.String, 4),
        new JdeField("EEOORN", "EEOORN", JdeDataType.String, 16, true, true),
        new JdeField("EEOCTO", "EEOCTO", JdeDataType.String, 4),
        new JdeField("EEITM", "EEITM", JdeDataType.Numeric),
        new JdeField("EEMMCU", "EEMMCU", JdeDataType.String, 24),
        new JdeField("EEREMK", "EEREMK", JdeDataType.String, 60),
        new JdeField("EEDSE", "EEDSE", JdeDataType.Numeric),
        new JdeField("EEBEGT", "EEBEGT", JdeDataType.Numeric),
        new JdeField("EEATFN", "EEATFN", JdeDataType.Numeric),
        new JdeField("EETMCO", "EETMCO", JdeDataType.Numeric),
        new JdeField("EEURDT", "EEURDT", JdeDataType.Numeric),
        new JdeField("EEURCD", "EEURCD", JdeDataType.String, 4),
        new JdeField("EEURAB", "EEURAB", JdeDataType.Numeric),
        new JdeField("EEURAT", "EEURAT", JdeDataType.Numeric),
        new JdeField("EEURRF", "EEURRF", JdeDataType.String, 30),
        new JdeField("EEUSER", "EEUSER", JdeDataType.String, 20),
        new JdeField("EEPID", "EEPID", JdeDataType.String, 20),
        new JdeField("EEJOBN", "EEJOBN", JdeDataType.String, 20),
        new JdeField("EEUPMJ", "EEUPMJ", JdeDataType.Numeric),
        new JdeField("EEUPMT", "EEUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1713_0", "Primary Key on EENUMB, EEDOCO, EEOORN", new[] { "EENUMB", "EEDOCO", "EEOORN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F1713_4", "Index on EEOORN, EENUMB, EEDOCO", new[] { "EEOORN", "EENUMB", "EEDOCO" }),
        new JdeIndex("F1713_5", "Index on EEDOCO, EENUMB, EEOORN", new[] { "EEDOCO", "EENUMB", "EEOORN" })
    };
}
