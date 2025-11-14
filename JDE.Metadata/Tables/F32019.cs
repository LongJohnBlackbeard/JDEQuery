using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F32019 - .
/// </summary>
public class F32019 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CHCFGID.
        /// </summary>
        public const string CHCFGID = "CHCFGID";

        /// <summary>
        /// CHKCOO.
        /// </summary>
        public const string CHKCOO = "CHKCOO";

        /// <summary>
        /// CHDOCO.
        /// </summary>
        public const string CHDOCO = "CHDOCO";

        /// <summary>
        /// CHDCTO.
        /// </summary>
        public const string CHDCTO = "CHDCTO";

        /// <summary>
        /// CHSFXO.
        /// </summary>
        public const string CHSFXO = "CHSFXO";

        /// <summary>
        /// CHLNID.
        /// </summary>
        public const string CHLNID = "CHLNID";

        /// <summary>
        /// CHCFGCID.
        /// </summary>
        public const string CHCFGCID = "CHCFGCID";

        /// <summary>
        /// CHSY.
        /// </summary>
        public const string CHSY = "CHSY";

        /// <summary>
        /// CHAN8.
        /// </summary>
        public const string CHAN8 = "CHAN8";

        /// <summary>
        /// CHSHAN.
        /// </summary>
        public const string CHSHAN = "CHSHAN";

        /// <summary>
        /// CHEMCU.
        /// </summary>
        public const string CHEMCU = "CHEMCU";

        /// <summary>
        /// CHCO.
        /// </summary>
        public const string CHCO = "CHCO";

        /// <summary>
        /// CHCRRM.
        /// </summary>
        public const string CHCRRM = "CHCRRM";

        /// <summary>
        /// CHCRCD.
        /// </summary>
        public const string CHCRCD = "CHCRCD";

        /// <summary>
        /// CHCRDC.
        /// </summary>
        public const string CHCRDC = "CHCRDC";

        /// <summary>
        /// CHURCD.
        /// </summary>
        public const string CHURCD = "CHURCD";

        /// <summary>
        /// CHURDT.
        /// </summary>
        public const string CHURDT = "CHURDT";

        /// <summary>
        /// CHURAT.
        /// </summary>
        public const string CHURAT = "CHURAT";

        /// <summary>
        /// CHURAB.
        /// </summary>
        public const string CHURAB = "CHURAB";

        /// <summary>
        /// CHURRF.
        /// </summary>
        public const string CHURRF = "CHURRF";

        /// <summary>
        /// CHUSER.
        /// </summary>
        public const string CHUSER = "CHUSER";

        /// <summary>
        /// CHPID.
        /// </summary>
        public const string CHPID = "CHPID";

        /// <summary>
        /// CHJOBN.
        /// </summary>
        public const string CHJOBN = "CHJOBN";

        /// <summary>
        /// CHUPMJ.
        /// </summary>
        public const string CHUPMJ = "CHUPMJ";

        /// <summary>
        /// CHTDAY.
        /// </summary>
        public const string CHTDAY = "CHTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F32019";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CHCFGID", "CHCFGID", JdeDataType.Numeric, null, true, true),
        new JdeField("CHKCOO", "CHKCOO", JdeDataType.String, 10, true, true),
        new JdeField("CHDOCO", "CHDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("CHDCTO", "CHDCTO", JdeDataType.String, 4, true, true),
        new JdeField("CHSFXO", "CHSFXO", JdeDataType.String, 6, true, true),
        new JdeField("CHLNID", "CHLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("CHCFGCID", "CHCFGCID", JdeDataType.Numeric),
        new JdeField("CHSY", "CHSY", JdeDataType.String, 8),
        new JdeField("CHAN8", "CHAN8", JdeDataType.Numeric),
        new JdeField("CHSHAN", "CHSHAN", JdeDataType.Numeric),
        new JdeField("CHEMCU", "CHEMCU", JdeDataType.String, 24),
        new JdeField("CHCO", "CHCO", JdeDataType.String, 10),
        new JdeField("CHCRRM", "CHCRRM", JdeDataType.String, 2),
        new JdeField("CHCRCD", "CHCRCD", JdeDataType.String, 6),
        new JdeField("CHCRDC", "CHCRDC", JdeDataType.String, 6),
        new JdeField("CHURCD", "CHURCD", JdeDataType.String, 4),
        new JdeField("CHURDT", "CHURDT", JdeDataType.Numeric),
        new JdeField("CHURAT", "CHURAT", JdeDataType.Numeric),
        new JdeField("CHURAB", "CHURAB", JdeDataType.Numeric),
        new JdeField("CHURRF", "CHURRF", JdeDataType.String, 30),
        new JdeField("CHUSER", "CHUSER", JdeDataType.String, 20),
        new JdeField("CHPID", "CHPID", JdeDataType.String, 20),
        new JdeField("CHJOBN", "CHJOBN", JdeDataType.String, 20),
        new JdeField("CHUPMJ", "CHUPMJ", JdeDataType.Numeric),
        new JdeField("CHTDAY", "CHTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F32019_0", "Primary Key on CHCFGID, CHKCOO, CHDOCO, CHDCTO, CHSFXO, CHLNID", new[] { "CHCFGID", "CHKCOO", "CHDOCO", "CHDCTO", "CHSFXO", "CHLNID" }, isUnique: true, isPrimaryKey: true)
    };
}
