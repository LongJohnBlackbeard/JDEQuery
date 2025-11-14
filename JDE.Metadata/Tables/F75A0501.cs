using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75A0501 - .
/// </summary>
public class F75A0501 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// THAUBP.
        /// </summary>
        public const string THAUBP = "THAUBP";

        /// <summary>
        /// THCKCN.
        /// </summary>
        public const string THCKCN = "THCKCN";

        /// <summary>
        /// THMEOT.
        /// </summary>
        public const string THMEOT = "THMEOT";

        /// <summary>
        /// THCKDT.
        /// </summary>
        public const string THCKDT = "THCKDT";

        /// <summary>
        /// THTARA.
        /// </summary>
        public const string THTARA = "THTARA";

        /// <summary>
        /// THPTAX.
        /// </summary>
        public const string THPTAX = "THPTAX";

        /// <summary>
        /// THEFTB.
        /// </summary>
        public const string THEFTB = "THEFTB";

        /// <summary>
        /// THEFTE.
        /// </summary>
        public const string THEFTE = "THEFTE";

        /// <summary>
        /// THAN8.
        /// </summary>
        public const string THAN8 = "THAN8";

        /// <summary>
        /// THHMCO.
        /// </summary>
        public const string THHMCO = "THHMCO";

        /// <summary>
        /// THTAXX.
        /// </summary>
        public const string THTAXX = "THTAXX";

        /// <summary>
        /// THPCCD.
        /// </summary>
        public const string THPCCD = "THPCCD";

        /// <summary>
        /// THPFRQ.
        /// </summary>
        public const string THPFRQ = "THPFRQ";

        /// <summary>
        /// THATA.
        /// </summary>
        public const string THATA = "THATA";

        /// <summary>
        /// THAPGP.
        /// </summary>
        public const string THAPGP = "THAPGP";

        /// <summary>
        /// THAPTP.
        /// </summary>
        public const string THAPTP = "THAPTP";

        /// <summary>
        /// THOPNW.
        /// </summary>
        public const string THOPNW = "THOPNW";

        /// <summary>
        /// THDPNW.
        /// </summary>
        public const string THDPNW = "THDPNW";

        /// <summary>
        /// THPNTX.
        /// </summary>
        public const string THPNTX = "THPNTX";

        /// <summary>
        /// THACGW.
        /// </summary>
        public const string THACGW = "THACGW";

        /// <summary>
        /// THACTAX.
        /// </summary>
        public const string THACTAX = "THACTAX";

        /// <summary>
        /// THAUNP.
        /// </summary>
        public const string THAUNP = "THAUNP";

        /// <summary>
        /// THANTP.
        /// </summary>
        public const string THANTP = "THANTP";

        /// <summary>
        /// THUSER.
        /// </summary>
        public const string THUSER = "THUSER";

        /// <summary>
        /// THPID.
        /// </summary>
        public const string THPID = "THPID";

        /// <summary>
        /// THJOBN.
        /// </summary>
        public const string THJOBN = "THJOBN";

        /// <summary>
        /// THUPMT.
        /// </summary>
        public const string THUPMT = "THUPMT";

        /// <summary>
        /// THUPMJ.
        /// </summary>
        public const string THUPMJ = "THUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F75A0501";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("THAUBP", "THAUBP", JdeDataType.String, 2, true, true),
        new JdeField("THCKCN", "THCKCN", JdeDataType.Numeric, null, true, true),
        new JdeField("THMEOT", "THMEOT", JdeDataType.String, 2, true, true),
        new JdeField("THCKDT", "THCKDT", JdeDataType.Numeric, null, true, true),
        new JdeField("THTARA", "THTARA", JdeDataType.String, 20, true, true),
        new JdeField("THPTAX", "THPTAX", JdeDataType.String, 4, true, true),
        new JdeField("THEFTB", "THEFTB", JdeDataType.Numeric, null, true, true),
        new JdeField("THEFTE", "THEFTE", JdeDataType.Numeric, null, true, true),
        new JdeField("THAN8", "THAN8", JdeDataType.Numeric),
        new JdeField("THHMCO", "THHMCO", JdeDataType.String, 10),
        new JdeField("THTAXX", "THTAXX", JdeDataType.String, 40),
        new JdeField("THPCCD", "THPCCD", JdeDataType.String, 10),
        new JdeField("THPFRQ", "THPFRQ", JdeDataType.String, 2),
        new JdeField("THATA", "THATA", JdeDataType.Numeric),
        new JdeField("THAPGP", "THAPGP", JdeDataType.Numeric),
        new JdeField("THAPTP", "THAPTP", JdeDataType.Numeric),
        new JdeField("THOPNW", "THOPNW", JdeDataType.Numeric),
        new JdeField("THDPNW", "THDPNW", JdeDataType.Numeric),
        new JdeField("THPNTX", "THPNTX", JdeDataType.Numeric),
        new JdeField("THACGW", "THACGW", JdeDataType.Numeric),
        new JdeField("THACTAX", "THACTAX", JdeDataType.Numeric),
        new JdeField("THAUNP", "THAUNP", JdeDataType.Numeric),
        new JdeField("THANTP", "THANTP", JdeDataType.Numeric),
        new JdeField("THUSER", "THUSER", JdeDataType.String, 20),
        new JdeField("THPID", "THPID", JdeDataType.String, 20),
        new JdeField("THJOBN", "THJOBN", JdeDataType.String, 20),
        new JdeField("THUPMT", "THUPMT", JdeDataType.Numeric),
        new JdeField("THUPMJ", "THUPMJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75A0501_0", "Primary Key on THCKCN, THAUBP, THCKDT, THMEOT, THTARA, THPTAX, THEFTB, THEFTE", new[] { "THCKCN", "THAUBP", "THCKDT", "THMEOT", "THTARA", "THPTAX", "THEFTB", "THEFTE" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F75A0501_2", "Index on THAN8, THCKCN", new[] { "THAN8", "THCKCN" })
    };
}
