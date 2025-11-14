using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FCW32 - .
/// </summary>
public class FCW32 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WSITM.
        /// </summary>
        public const string WSITM = "WSITM";

        /// <summary>
        /// WSEV01.
        /// </summary>
        public const string WSEV01 = "WSEV01";

        /// <summary>
        /// WSHSCD.
        /// </summary>
        public const string WSHSCD = "WSHSCD";

        /// <summary>
        /// WSPDCG.
        /// </summary>
        public const string WSPDCG = "WSPDCG";

        /// <summary>
        /// WSPFCT.
        /// </summary>
        public const string WSPFCT = "WSPFCT";

        /// <summary>
        /// WSDMFR.
        /// </summary>
        public const string WSDMFR = "WSDMFR";

        /// <summary>
        /// WSECCN.
        /// </summary>
        public const string WSECCN = "WSECCN";

        /// <summary>
        /// WSUNNA.
        /// </summary>
        public const string WSUNNA = "WSUNNA";

        /// <summary>
        /// WSHZDC.
        /// </summary>
        public const string WSHZDC = "WSHZDC";

        /// <summary>
        /// WSPKGP.
        /// </summary>
        public const string WSPKGP = "WSPKGP";

        /// <summary>
        /// WSSRSK.
        /// </summary>
        public const string WSSRSK = "WSSRSK";

        /// <summary>
        /// WSFPNT.
        /// </summary>
        public const string WSFPNT = "WSFPNT";

        /// <summary>
        /// WSSTPU.
        /// </summary>
        public const string WSSTPU = "WSSTPU";

        /// <summary>
        /// WSPKIN.
        /// </summary>
        public const string WSPKIN = "WSPKIN";

        /// <summary>
        /// WSHZDL.
        /// </summary>
        public const string WSHZDL = "WSHZDL";

        /// <summary>
        /// WSNMFI.
        /// </summary>
        public const string WSNMFI = "WSNMFI";

        /// <summary>
        /// WSNMFC.
        /// </summary>
        public const string WSNMFC = "WSNMFC";

        /// <summary>
        /// WSSTCC.
        /// </summary>
        public const string WSSTCC = "WSSTCC";

        /// <summary>
        /// WSFRT1.
        /// </summary>
        public const string WSFRT1 = "WSFRT1";

        /// <summary>
        /// WSFRT2.
        /// </summary>
        public const string WSFRT2 = "WSFRT2";

        /// <summary>
        /// WSUSER.
        /// </summary>
        public const string WSUSER = "WSUSER";

        /// <summary>
        /// WSPID.
        /// </summary>
        public const string WSPID = "WSPID";

        /// <summary>
        /// WSJOBN.
        /// </summary>
        public const string WSJOBN = "WSJOBN";

        /// <summary>
        /// WSUPMJ.
        /// </summary>
        public const string WSUPMJ = "WSUPMJ";

        /// <summary>
        /// WSTDAY.
        /// </summary>
        public const string WSTDAY = "WSTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "FCW32";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WSITM", "WSITM", JdeDataType.Numeric, null, true, true),
        new JdeField("WSEV01", "WSEV01", JdeDataType.String, 2, true, true),
        new JdeField("WSHSCD", "WSHSCD", JdeDataType.String, 24),
        new JdeField("WSPDCG", "WSPDCG", JdeDataType.String, 8),
        new JdeField("WSPFCT", "WSPFCT", JdeDataType.String, 2),
        new JdeField("WSDMFR", "WSDMFR", JdeDataType.String, 2),
        new JdeField("WSECCN", "WSECCN", JdeDataType.String, 20),
        new JdeField("WSUNNA", "WSUNNA", JdeDataType.String, 12),
        new JdeField("WSHZDC", "WSHZDC", JdeDataType.String, 6),
        new JdeField("WSPKGP", "WSPKGP", JdeDataType.String, 6),
        new JdeField("WSSRSK", "WSSRSK", JdeDataType.String, 6),
        new JdeField("WSFPNT", "WSFPNT", JdeDataType.Numeric),
        new JdeField("WSSTPU", "WSSTPU", JdeDataType.String, 2),
        new JdeField("WSPKIN", "WSPKIN", JdeDataType.String, 8),
        new JdeField("WSHZDL", "WSHZDL", JdeDataType.String, 6),
        new JdeField("WSNMFI", "WSNMFI", JdeDataType.String, 12),
        new JdeField("WSNMFC", "WSNMFC", JdeDataType.String, 8),
        new JdeField("WSSTCC", "WSSTCC", JdeDataType.String, 20),
        new JdeField("WSFRT1", "WSFRT1", JdeDataType.String, 12),
        new JdeField("WSFRT2", "WSFRT2", JdeDataType.String, 12),
        new JdeField("WSUSER", "WSUSER", JdeDataType.String, 20),
        new JdeField("WSPID", "WSPID", JdeDataType.String, 20),
        new JdeField("WSJOBN", "WSJOBN", JdeDataType.String, 20),
        new JdeField("WSUPMJ", "WSUPMJ", JdeDataType.Numeric),
        new JdeField("WSTDAY", "WSTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FCW32_0", "Primary Key on WSITM, WSEV01", new[] { "WSITM", "WSEV01" }, isUnique: true, isPrimaryKey: true)
    };
}
