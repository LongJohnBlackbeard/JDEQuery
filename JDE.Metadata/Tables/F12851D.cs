using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F12851D - .
/// </summary>
public class F12851D : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LUDESC.
        /// </summary>
        public const string LUDESC = "LUDESC";

        /// <summary>
        /// LUADM.
        /// </summary>
        public const string LUADM = "LUADM";

        /// <summary>
        /// LUADLM.
        /// </summary>
        public const string LUADLM = "LUADLM";

        /// <summary>
        /// LUITAC.
        /// </summary>
        public const string LUITAC = "LUITAC";

        /// <summary>
        /// LUDIR1.
        /// </summary>
        public const string LUDIR1 = "LUDIR1";

        /// <summary>
        /// LUDTFR.
        /// </summary>
        public const string LUDTFR = "LUDTFR";

        /// <summary>
        /// LUDTTO.
        /// </summary>
        public const string LUDTTO = "LUDTTO";

        /// <summary>
        /// LUEFTB.
        /// </summary>
        public const string LUEFTB = "LUEFTB";

        /// <summary>
        /// LUEFTE.
        /// </summary>
        public const string LUEFTE = "LUEFTE";

        /// <summary>
        /// LUDBUC.
        /// </summary>
        public const string LUDBUC = "LUDBUC";

        /// <summary>
        /// LUDTPN.
        /// </summary>
        public const string LUDTPN = "LUDTPN";

        /// <summary>
        /// LUFYSC.
        /// </summary>
        public const string LUFYSC = "LUFYSC";

        /// <summary>
        /// LULYRC.
        /// </summary>
        public const string LULYRC = "LULYRC";

        /// <summary>
        /// LULYSC.
        /// </summary>
        public const string LULYSC = "LULYSC";

        /// <summary>
        /// LUDYDC.
        /// </summary>
        public const string LUDYDC = "LUDYDC";

        /// <summary>
        /// LUOUDC.
        /// </summary>
        public const string LUOUDC = "LUOUDC";

        /// <summary>
        /// LUNDAC.
        /// </summary>
        public const string LUNDAC = "LUNDAC";

        /// <summary>
        /// LUSDAC.
        /// </summary>
        public const string LUSDAC = "LUSDAC";

        /// <summary>
        /// LUDPCF.
        /// </summary>
        public const string LUDPCF = "LUDPCF";

        /// <summary>
        /// LUEDEN.
        /// </summary>
        public const string LUEDEN = "LUEDEN";

        /// <summary>
        /// LULCT.
        /// </summary>
        public const string LULCT = "LULCT";

        /// <summary>
        /// LUUSER.
        /// </summary>
        public const string LUUSER = "LUUSER";

        /// <summary>
        /// LUPID.
        /// </summary>
        public const string LUPID = "LUPID";

        /// <summary>
        /// LUUPMJ.
        /// </summary>
        public const string LUUPMJ = "LUUPMJ";

        /// <summary>
        /// LUJOBN.
        /// </summary>
        public const string LUJOBN = "LUJOBN";

        /// <summary>
        /// LUUPMT.
        /// </summary>
        public const string LUUPMT = "LUUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F12851D";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LUDESC", "LUDESC", JdeDataType.String, 60),
        new JdeField("LUADM", "LUADM", JdeDataType.String, 4, true, true),
        new JdeField("LUADLM", "LUADLM", JdeDataType.Numeric, null, true, true),
        new JdeField("LUITAC", "LUITAC", JdeDataType.String, 2, true, true),
        new JdeField("LUDIR1", "LUDIR1", JdeDataType.String, 2, true, true),
        new JdeField("LUDTFR", "LUDTFR", JdeDataType.Numeric, null, true, true),
        new JdeField("LUDTTO", "LUDTTO", JdeDataType.Numeric),
        new JdeField("LUEFTB", "LUEFTB", JdeDataType.Numeric, null, true, true),
        new JdeField("LUEFTE", "LUEFTE", JdeDataType.Numeric),
        new JdeField("LUDBUC", "LUDBUC", JdeDataType.String, 2),
        new JdeField("LUDTPN", "LUDTPN", JdeDataType.String, 2),
        new JdeField("LUFYSC", "LUFYSC", JdeDataType.String, 2),
        new JdeField("LULYRC", "LULYRC", JdeDataType.String, 2),
        new JdeField("LULYSC", "LULYSC", JdeDataType.String, 2),
        new JdeField("LUDYDC", "LUDYDC", JdeDataType.String, 2),
        new JdeField("LUOUDC", "LUOUDC", JdeDataType.String, 2),
        new JdeField("LUNDAC", "LUNDAC", JdeDataType.String, 2),
        new JdeField("LUSDAC", "LUSDAC", JdeDataType.String, 2),
        new JdeField("LUDPCF", "LUDPCF", JdeDataType.String, 2),
        new JdeField("LUEDEN", "LUEDEN", JdeDataType.String, 2),
        new JdeField("LULCT", "LULCT", JdeDataType.Numeric),
        new JdeField("LUUSER", "LUUSER", JdeDataType.String, 20),
        new JdeField("LUPID", "LUPID", JdeDataType.String, 20),
        new JdeField("LUUPMJ", "LUUPMJ", JdeDataType.Numeric),
        new JdeField("LUJOBN", "LUJOBN", JdeDataType.String, 20),
        new JdeField("LUUPMT", "LUUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F12851D_0", "Primary Key on LUADM, LUADLM, LUITAC, LUDIR1, LUDTFR, LUEFTB", new[] { "LUADM", "LUADLM", "LUITAC", "LUDIR1", "LUDTFR", "LUEFTB" }, isUnique: true, isPrimaryKey: true)
    };
}
