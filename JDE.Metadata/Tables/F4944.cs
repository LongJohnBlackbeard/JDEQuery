using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4944 - .
/// </summary>
public class F4944 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// OESHPN.
        /// </summary>
        public const string OESHPN = "OESHPN";

        /// <summary>
        /// OERSSN.
        /// </summary>
        public const string OERSSN = "OERSSN";

        /// <summary>
        /// OEVMCU.
        /// </summary>
        public const string OEVMCU = "OEVMCU";

        /// <summary>
        /// OELDNM.
        /// </summary>
        public const string OELDNM = "OELDNM";

        /// <summary>
        /// OEDOCO.
        /// </summary>
        public const string OEDOCO = "OEDOCO";

        /// <summary>
        /// OEDCTO.
        /// </summary>
        public const string OEDCTO = "OEDCTO";

        /// <summary>
        /// OEKCOO.
        /// </summary>
        public const string OEKCOO = "OEKCOO";

        /// <summary>
        /// OELNID.
        /// </summary>
        public const string OELNID = "OELNID";

        /// <summary>
        /// OEOPEQ.
        /// </summary>
        public const string OEOPEQ = "OEOPEQ";

        /// <summary>
        /// OEDLLV.
        /// </summary>
        public const string OEDLLV = "OEDLLV";

        /// <summary>
        /// OEOEOV.
        /// </summary>
        public const string OEOEOV = "OEOEOV";

        /// <summary>
        /// OEURCD.
        /// </summary>
        public const string OEURCD = "OEURCD";

        /// <summary>
        /// OEURDT.
        /// </summary>
        public const string OEURDT = "OEURDT";

        /// <summary>
        /// OEURAT.
        /// </summary>
        public const string OEURAT = "OEURAT";

        /// <summary>
        /// OEURAB.
        /// </summary>
        public const string OEURAB = "OEURAB";

        /// <summary>
        /// OEURRF.
        /// </summary>
        public const string OEURRF = "OEURRF";

        /// <summary>
        /// OEUSER.
        /// </summary>
        public const string OEUSER = "OEUSER";

        /// <summary>
        /// OEPID.
        /// </summary>
        public const string OEPID = "OEPID";

        /// <summary>
        /// OEJOBN.
        /// </summary>
        public const string OEJOBN = "OEJOBN";

        /// <summary>
        /// OEUPMJ.
        /// </summary>
        public const string OEUPMJ = "OEUPMJ";

        /// <summary>
        /// OETDAY.
        /// </summary>
        public const string OETDAY = "OETDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F4944";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("OESHPN", "OESHPN", JdeDataType.Numeric, null, true, true),
        new JdeField("OERSSN", "OERSSN", JdeDataType.Numeric, null, true, true),
        new JdeField("OEVMCU", "OEVMCU", JdeDataType.String, 24, true, true),
        new JdeField("OELDNM", "OELDNM", JdeDataType.Numeric, null, true, true),
        new JdeField("OEDOCO", "OEDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("OEDCTO", "OEDCTO", JdeDataType.String, 4, true, true),
        new JdeField("OEKCOO", "OEKCOO", JdeDataType.String, 10, true, true),
        new JdeField("OELNID", "OELNID", JdeDataType.Numeric, null, true, true),
        new JdeField("OEOPEQ", "OEOPEQ", JdeDataType.String, 20, true, true),
        new JdeField("OEDLLV", "OEDLLV", JdeDataType.String, 2),
        new JdeField("OEOEOV", "OEOEOV", JdeDataType.String, 2),
        new JdeField("OEURCD", "OEURCD", JdeDataType.String, 4),
        new JdeField("OEURDT", "OEURDT", JdeDataType.Numeric),
        new JdeField("OEURAT", "OEURAT", JdeDataType.Numeric),
        new JdeField("OEURAB", "OEURAB", JdeDataType.Numeric),
        new JdeField("OEURRF", "OEURRF", JdeDataType.String, 30),
        new JdeField("OEUSER", "OEUSER", JdeDataType.String, 20),
        new JdeField("OEPID", "OEPID", JdeDataType.String, 20),
        new JdeField("OEJOBN", "OEJOBN", JdeDataType.String, 20),
        new JdeField("OEUPMJ", "OEUPMJ", JdeDataType.Numeric),
        new JdeField("OETDAY", "OETDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4944_0", "Primary Key on OESHPN, OERSSN, OEVMCU, OELDNM, OEDOCO, OEDCTO, OEKCOO, OELNID, OEOPEQ", new[] { "OESHPN", "OERSSN", "OEVMCU", "OELDNM", "OEDOCO", "OEDCTO", "OEKCOO", "OELNID", "OEOPEQ" }, isUnique: true, isPrimaryKey: true)
    };
}
