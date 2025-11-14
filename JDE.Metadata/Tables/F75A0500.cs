using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75A0500 - .
/// </summary>
public class F75A0500 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BPCKCN.
        /// </summary>
        public const string BPCKCN = "BPCKCN";

        /// <summary>
        /// BPAUBP.
        /// </summary>
        public const string BPAUBP = "BPAUBP";

        /// <summary>
        /// BPMEOT.
        /// </summary>
        public const string BPMEOT = "BPMEOT";

        /// <summary>
        /// BPCKDT.
        /// </summary>
        public const string BPCKDT = "BPCKDT";

        /// <summary>
        /// BPTARA.
        /// </summary>
        public const string BPTARA = "BPTARA";

        /// <summary>
        /// BPPTAX.
        /// </summary>
        public const string BPPTAX = "BPPTAX";

        /// <summary>
        /// BPEFTB.
        /// </summary>
        public const string BPEFTB = "BPEFTB";

        /// <summary>
        /// BPEFTE.
        /// </summary>
        public const string BPEFTE = "BPEFTE";

        /// <summary>
        /// BPAN8.
        /// </summary>
        public const string BPAN8 = "BPAN8";

        /// <summary>
        /// BPHMCO.
        /// </summary>
        public const string BPHMCO = "BPHMCO";

        /// <summary>
        /// BPTAXX.
        /// </summary>
        public const string BPTAXX = "BPTAXX";

        /// <summary>
        /// BPPCCD.
        /// </summary>
        public const string BPPCCD = "BPPCCD";

        /// <summary>
        /// BPPFRQ.
        /// </summary>
        public const string BPPFRQ = "BPPFRQ";

        /// <summary>
        /// BPATA.
        /// </summary>
        public const string BPATA = "BPATA";

        /// <summary>
        /// BPAPGP.
        /// </summary>
        public const string BPAPGP = "BPAPGP";

        /// <summary>
        /// BPAPTP.
        /// </summary>
        public const string BPAPTP = "BPAPTP";

        /// <summary>
        /// BPOPNW.
        /// </summary>
        public const string BPOPNW = "BPOPNW";

        /// <summary>
        /// BPDPNW.
        /// </summary>
        public const string BPDPNW = "BPDPNW";

        /// <summary>
        /// BPPNTX.
        /// </summary>
        public const string BPPNTX = "BPPNTX";

        /// <summary>
        /// BPACGW.
        /// </summary>
        public const string BPACGW = "BPACGW";

        /// <summary>
        /// BPACTAX.
        /// </summary>
        public const string BPACTAX = "BPACTAX";

        /// <summary>
        /// BPAUNP.
        /// </summary>
        public const string BPAUNP = "BPAUNP";

        /// <summary>
        /// BPANTP.
        /// </summary>
        public const string BPANTP = "BPANTP";

        /// <summary>
        /// BPUSER.
        /// </summary>
        public const string BPUSER = "BPUSER";

        /// <summary>
        /// BPPID.
        /// </summary>
        public const string BPPID = "BPPID";

        /// <summary>
        /// BPJOBN.
        /// </summary>
        public const string BPJOBN = "BPJOBN";

        /// <summary>
        /// BPUPMT.
        /// </summary>
        public const string BPUPMT = "BPUPMT";

        /// <summary>
        /// BPUPMJ.
        /// </summary>
        public const string BPUPMJ = "BPUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F75A0500";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BPCKCN", "BPCKCN", JdeDataType.Numeric, null, true, true),
        new JdeField("BPAUBP", "BPAUBP", JdeDataType.String, 2, true, true),
        new JdeField("BPMEOT", "BPMEOT", JdeDataType.String, 2, true, true),
        new JdeField("BPCKDT", "BPCKDT", JdeDataType.Numeric, null, true, true),
        new JdeField("BPTARA", "BPTARA", JdeDataType.String, 20, true, true),
        new JdeField("BPPTAX", "BPPTAX", JdeDataType.String, 4, true, true),
        new JdeField("BPEFTB", "BPEFTB", JdeDataType.Numeric, null, true, true),
        new JdeField("BPEFTE", "BPEFTE", JdeDataType.Numeric, null, true, true),
        new JdeField("BPAN8", "BPAN8", JdeDataType.Numeric),
        new JdeField("BPHMCO", "BPHMCO", JdeDataType.String, 10),
        new JdeField("BPTAXX", "BPTAXX", JdeDataType.String, 40),
        new JdeField("BPPCCD", "BPPCCD", JdeDataType.String, 10),
        new JdeField("BPPFRQ", "BPPFRQ", JdeDataType.String, 2),
        new JdeField("BPATA", "BPATA", JdeDataType.Numeric),
        new JdeField("BPAPGP", "BPAPGP", JdeDataType.Numeric),
        new JdeField("BPAPTP", "BPAPTP", JdeDataType.Numeric),
        new JdeField("BPOPNW", "BPOPNW", JdeDataType.Numeric),
        new JdeField("BPDPNW", "BPDPNW", JdeDataType.Numeric),
        new JdeField("BPPNTX", "BPPNTX", JdeDataType.Numeric),
        new JdeField("BPACGW", "BPACGW", JdeDataType.Numeric),
        new JdeField("BPACTAX", "BPACTAX", JdeDataType.Numeric),
        new JdeField("BPAUNP", "BPAUNP", JdeDataType.Numeric),
        new JdeField("BPANTP", "BPANTP", JdeDataType.Numeric),
        new JdeField("BPUSER", "BPUSER", JdeDataType.String, 20),
        new JdeField("BPPID", "BPPID", JdeDataType.String, 20),
        new JdeField("BPJOBN", "BPJOBN", JdeDataType.String, 20),
        new JdeField("BPUPMT", "BPUPMT", JdeDataType.Numeric),
        new JdeField("BPUPMJ", "BPUPMJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75A0500_0", "Primary Key on BPCKCN, BPAUBP, BPMEOT, BPCKDT, BPTARA, BPPTAX, BPEFTB, BPEFTE", new[] { "BPCKCN", "BPAUBP", "BPMEOT", "BPCKDT", "BPTARA", "BPPTAX", "BPEFTB", "BPEFTE" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F75A0500_2", "Index on BPAN8, BPCKCN", new[] { "BPAN8", "BPCKCN" })
    };
}
