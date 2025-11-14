using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F08711 - .
/// </summary>
public class F08711 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ETESID.
        /// </summary>
        public const string ETESID = "ETESID";

        /// <summary>
        /// ETTSKCD.
        /// </summary>
        public const string ETTSKCD = "ETTSKCD";

        /// <summary>
        /// ETTSKSTS.
        /// </summary>
        public const string ETTSKSTS = "ETTSKSTS";

        /// <summary>
        /// ETTSKC.
        /// </summary>
        public const string ETTSKC = "ETTSKC";

        /// <summary>
        /// ETDOCO.
        /// </summary>
        public const string ETDOCO = "ETDOCO";

        /// <summary>
        /// ETTYPS.
        /// </summary>
        public const string ETTYPS = "ETTYPS";

        /// <summary>
        /// ETU.
        /// </summary>
        public const string ETU = "ETU";

        /// <summary>
        /// ETUM.
        /// </summary>
        public const string ETUM = "ETUM";

        /// <summary>
        /// ETCOS.
        /// </summary>
        public const string ETCOS = "ETCOS";

        /// <summary>
        /// ETDUR.
        /// </summary>
        public const string ETDUR = "ETDUR";

        /// <summary>
        /// ETANR.
        /// </summary>
        public const string ETANR = "ETANR";

        /// <summary>
        /// ETDABS.
        /// </summary>
        public const string ETDABS = "ETDABS";

        /// <summary>
        /// ETAPRV.
        /// </summary>
        public const string ETAPRV = "ETAPRV";

        /// <summary>
        /// ETUPMJ.
        /// </summary>
        public const string ETUPMJ = "ETUPMJ";

        /// <summary>
        /// ETUSER.
        /// </summary>
        public const string ETUSER = "ETUSER";

        /// <summary>
        /// ETJOBN.
        /// </summary>
        public const string ETJOBN = "ETJOBN";

        /// <summary>
        /// ETPID.
        /// </summary>
        public const string ETPID = "ETPID";
    }

    /// <inheritdoc />
    public override string TableName => "F08711";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ETESID", "ETESID", JdeDataType.Numeric, null, true, true),
        new JdeField("ETTSKCD", "ETTSKCD", JdeDataType.Numeric, null, true, true),
        new JdeField("ETTSKSTS", "ETTSKSTS", JdeDataType.String, 4),
        new JdeField("ETTSKC", "ETTSKC", JdeDataType.String, 480),
        new JdeField("ETDOCO", "ETDOCO", JdeDataType.Numeric),
        new JdeField("ETTYPS", "ETTYPS", JdeDataType.String, 2),
        new JdeField("ETU", "ETU", JdeDataType.Numeric),
        new JdeField("ETUM", "ETUM", JdeDataType.String, 4),
        new JdeField("ETCOS", "ETCOS", JdeDataType.Numeric),
        new JdeField("ETDUR", "ETDUR", JdeDataType.Numeric),
        new JdeField("ETANR", "ETANR", JdeDataType.Numeric),
        new JdeField("ETDABS", "ETDABS", JdeDataType.String, 2),
        new JdeField("ETAPRV", "ETAPRV", JdeDataType.Numeric),
        new JdeField("ETUPMJ", "ETUPMJ", JdeDataType.Numeric),
        new JdeField("ETUSER", "ETUSER", JdeDataType.String, 20),
        new JdeField("ETJOBN", "ETJOBN", JdeDataType.String, 20),
        new JdeField("ETPID", "ETPID", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F08711_0", "Primary Key on ETESID, ETTSKCD", new[] { "ETESID", "ETTSKCD" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F08711_2", "Index on ETANR", new[] { "ETANR" }),
        new JdeIndex("F08711_3", "Index on ETTSKSTS", new[] { "ETTSKSTS" }),
        new JdeIndex("F08711_4", "Index on ETTSKCD", new[] { "ETTSKCD" })
    };
}
