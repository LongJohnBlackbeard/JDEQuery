using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74U0142 - .
/// </summary>
public class F74U0142 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DHKCOO.
        /// </summary>
        public const string DHKCOO = "DHKCOO";

        /// <summary>
        /// DHDOCO.
        /// </summary>
        public const string DHDOCO = "DHDOCO";

        /// <summary>
        /// DHDCTO.
        /// </summary>
        public const string DHDCTO = "DHDCTO";

        /// <summary>
        /// DHSFXO.
        /// </summary>
        public const string DHSFXO = "DHSFXO";

        /// <summary>
        /// DHLNID.
        /// </summary>
        public const string DHLNID = "DHLNID";

        /// <summary>
        /// DHEFTB.
        /// </summary>
        public const string DHEFTB = "DHEFTB";

        /// <summary>
        /// DHBEGT.
        /// </summary>
        public const string DHBEGT = "DHBEGT";

        /// <summary>
        /// DHUKAPDN.
        /// </summary>
        public const string DHUKAPDN = "DHUKAPDN";

        /// <summary>
        /// DHUKCENM.
        /// </summary>
        public const string DHUKCENM = "DHUKCENM";

        /// <summary>
        /// DHUKAPDS.
        /// </summary>
        public const string DHUKAPDS = "DHUKAPDS";

        /// <summary>
        /// DHEFTE.
        /// </summary>
        public const string DHEFTE = "DHEFTE";

        /// <summary>
        /// DHENDT.
        /// </summary>
        public const string DHENDT = "DHENDT";

        /// <summary>
        /// DHSTHR.
        /// </summary>
        public const string DHSTHR = "DHSTHR";

        /// <summary>
        /// DHCUMH.
        /// </summary>
        public const string DHCUMH = "DHCUMH";

        /// <summary>
        /// DHRMK.
        /// </summary>
        public const string DHRMK = "DHRMK";

        /// <summary>
        /// DHUKACC1.
        /// </summary>
        public const string DHUKACC1 = "DHUKACC1";

        /// <summary>
        /// DHUKACC2.
        /// </summary>
        public const string DHUKACC2 = "DHUKACC2";

        /// <summary>
        /// DHUKACS1.
        /// </summary>
        public const string DHUKACS1 = "DHUKACS1";

        /// <summary>
        /// DHUKACS2.
        /// </summary>
        public const string DHUKACS2 = "DHUKACS2";

        /// <summary>
        /// DHUKACN1.
        /// </summary>
        public const string DHUKACN1 = "DHUKACN1";

        /// <summary>
        /// DHUKACN2.
        /// </summary>
        public const string DHUKACN2 = "DHUKACN2";

        /// <summary>
        /// DHUSER.
        /// </summary>
        public const string DHUSER = "DHUSER";

        /// <summary>
        /// DHPID.
        /// </summary>
        public const string DHPID = "DHPID";

        /// <summary>
        /// DHUPMJ.
        /// </summary>
        public const string DHUPMJ = "DHUPMJ";

        /// <summary>
        /// DHUPMT.
        /// </summary>
        public const string DHUPMT = "DHUPMT";

        /// <summary>
        /// DHJOBN.
        /// </summary>
        public const string DHJOBN = "DHJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F74U0142";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DHKCOO", "DHKCOO", JdeDataType.String, 10, true, true),
        new JdeField("DHDOCO", "DHDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("DHDCTO", "DHDCTO", JdeDataType.String, 4, true, true),
        new JdeField("DHSFXO", "DHSFXO", JdeDataType.String, 6, true, true),
        new JdeField("DHLNID", "DHLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("DHEFTB", "DHEFTB", JdeDataType.Numeric, null, true, true),
        new JdeField("DHBEGT", "DHBEGT", JdeDataType.Numeric, null, true, true),
        new JdeField("DHUKAPDN", "DHUKAPDN", JdeDataType.Numeric),
        new JdeField("DHUKCENM", "DHUKCENM", JdeDataType.Numeric),
        new JdeField("DHUKAPDS", "DHUKAPDS", JdeDataType.String, 2),
        new JdeField("DHEFTE", "DHEFTE", JdeDataType.Numeric),
        new JdeField("DHENDT", "DHENDT", JdeDataType.Numeric),
        new JdeField("DHSTHR", "DHSTHR", JdeDataType.Numeric),
        new JdeField("DHCUMH", "DHCUMH", JdeDataType.Numeric),
        new JdeField("DHRMK", "DHRMK", JdeDataType.String, 60),
        new JdeField("DHUKACC1", "DHUKACC1", JdeDataType.String, 2),
        new JdeField("DHUKACC2", "DHUKACC2", JdeDataType.String, 2),
        new JdeField("DHUKACS1", "DHUKACS1", JdeDataType.String, 60),
        new JdeField("DHUKACS2", "DHUKACS2", JdeDataType.String, 60),
        new JdeField("DHUKACN1", "DHUKACN1", JdeDataType.Numeric),
        new JdeField("DHUKACN2", "DHUKACN2", JdeDataType.Numeric),
        new JdeField("DHUSER", "DHUSER", JdeDataType.String, 20),
        new JdeField("DHPID", "DHPID", JdeDataType.String, 20),
        new JdeField("DHUPMJ", "DHUPMJ", JdeDataType.Numeric),
        new JdeField("DHUPMT", "DHUPMT", JdeDataType.Numeric),
        new JdeField("DHJOBN", "DHJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74U0142_0", "Primary Key on DHKCOO, DHDOCO, DHDCTO, DHSFXO, DHLNID, DHEFTB, DHBEGT", new[] { "DHKCOO", "DHDOCO", "DHDCTO", "DHSFXO", "DHLNID", "DHEFTB", "DHBEGT" }, isUnique: true, isPrimaryKey: true)
    };
}
