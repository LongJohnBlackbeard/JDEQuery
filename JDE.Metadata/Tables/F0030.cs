using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0030 - .
/// </summary>
public class F0030 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// AYBKTP.
        /// </summary>
        public const string AYBKTP = "AYBKTP";

        /// <summary>
        /// AYTNST.
        /// </summary>
        public const string AYTNST = "AYTNST";

        /// <summary>
        /// AYCBNK.
        /// </summary>
        public const string AYCBNK = "AYCBNK";

        /// <summary>
        /// AYAN8.
        /// </summary>
        public const string AYAN8 = "AYAN8";

        /// <summary>
        /// AYDL01.
        /// </summary>
        public const string AYDL01 = "AYDL01";

        /// <summary>
        /// AYAID.
        /// </summary>
        public const string AYAID = "AYAID";

        /// <summary>
        /// AYNXTC.
        /// </summary>
        public const string AYNXTC = "AYNXTC";

        /// <summary>
        /// AYCHKD.
        /// </summary>
        public const string AYCHKD = "AYCHKD";

        /// <summary>
        /// AYCRCD.
        /// </summary>
        public const string AYCRCD = "AYCRCD";

        /// <summary>
        /// AYRLN.
        /// </summary>
        public const string AYRLN = "AYRLN";

        /// <summary>
        /// AYBACS.
        /// </summary>
        public const string AYBACS = "AYBACS";

        /// <summary>
        /// AYRFNM.
        /// </summary>
        public const string AYRFNM = "AYRFNM";

        /// <summary>
        /// AYBAID.
        /// </summary>
        public const string AYBAID = "AYBAID";

        /// <summary>
        /// AYMCU.
        /// </summary>
        public const string AYMCU = "AYMCU";

        /// <summary>
        /// AYSWFT.
        /// </summary>
        public const string AYSWFT = "AYSWFT";

        /// <summary>
        /// AYADPI.
        /// </summary>
        public const string AYADPI = "AYADPI";

        /// <summary>
        /// AYCHKQ.
        /// </summary>
        public const string AYCHKQ = "AYCHKQ";

        /// <summary>
        /// AYATTQ.
        /// </summary>
        public const string AYATTQ = "AYATTQ";

        /// <summary>
        /// AYDBTQ.
        /// </summary>
        public const string AYDBTQ = "AYDBTQ";

        /// <summary>
        /// AYALGN.
        /// </summary>
        public const string AYALGN = "AYALGN";

        /// <summary>
        /// AYSDTL.
        /// </summary>
        public const string AYSDTL = "AYSDTL";

        /// <summary>
        /// AYFLR.
        /// </summary>
        public const string AYFLR = "AYFLR";

        /// <summary>
        /// AYFLP.
        /// </summary>
        public const string AYFLP = "AYFLP";

        /// <summary>
        /// AYCKSV.
        /// </summary>
        public const string AYCKSV = "AYCKSV";

        /// <summary>
        /// AYUKID.
        /// </summary>
        public const string AYUKID = "AYUKID";

        /// <summary>
        /// AYCTR.
        /// </summary>
        public const string AYCTR = "AYCTR";

        /// <summary>
        /// AYNXTA.
        /// </summary>
        public const string AYNXTA = "AYNXTA";

        /// <summary>
        /// AYUPMJ.
        /// </summary>
        public const string AYUPMJ = "AYUPMJ";

        /// <summary>
        /// AYUPMT.
        /// </summary>
        public const string AYUPMT = "AYUPMT";

        /// <summary>
        /// AYPID.
        /// </summary>
        public const string AYPID = "AYPID";

        /// <summary>
        /// AYUSER.
        /// </summary>
        public const string AYUSER = "AYUSER";

        /// <summary>
        /// AYJOBN.
        /// </summary>
        public const string AYJOBN = "AYJOBN";

        /// <summary>
        /// AYIBAN.
        /// </summary>
        public const string AYIBAN = "AYIBAN";

        /// <summary>
        /// AYAN8BK.
        /// </summary>
        public const string AYAN8BK = "AYAN8BK";
    }

    /// <inheritdoc />
    public override string TableName => "F0030";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("AYBKTP", "AYBKTP", JdeDataType.String, 2),
        new JdeField("AYTNST", "AYTNST", JdeDataType.String, 40),
        new JdeField("AYCBNK", "AYCBNK", JdeDataType.String, 40),
        new JdeField("AYAN8", "AYAN8", JdeDataType.Numeric),
        new JdeField("AYDL01", "AYDL01", JdeDataType.String, 60),
        new JdeField("AYAID", "AYAID", JdeDataType.String, 16),
        new JdeField("AYNXTC", "AYNXTC", JdeDataType.Numeric),
        new JdeField("AYCHKD", "AYCHKD", JdeDataType.String, 4),
        new JdeField("AYCRCD", "AYCRCD", JdeDataType.String, 6),
        new JdeField("AYRLN", "AYRLN", JdeDataType.String, 36),
        new JdeField("AYBACS", "AYBACS", JdeDataType.Numeric),
        new JdeField("AYRFNM", "AYRFNM", JdeDataType.String, 36),
        new JdeField("AYBAID", "AYBAID", JdeDataType.String, 16),
        new JdeField("AYMCU", "AYMCU", JdeDataType.String, 24),
        new JdeField("AYSWFT", "AYSWFT", JdeDataType.String, 30),
        new JdeField("AYADPI", "AYADPI", JdeDataType.String, 2),
        new JdeField("AYCHKQ", "AYCHKQ", JdeDataType.String, 20),
        new JdeField("AYATTQ", "AYATTQ", JdeDataType.String, 20),
        new JdeField("AYDBTQ", "AYDBTQ", JdeDataType.String, 20),
        new JdeField("AYALGN", "AYALGN", JdeDataType.Numeric),
        new JdeField("AYSDTL", "AYSDTL", JdeDataType.Numeric),
        new JdeField("AYFLR", "AYFLR", JdeDataType.Numeric),
        new JdeField("AYFLP", "AYFLP", JdeDataType.Numeric),
        new JdeField("AYCKSV", "AYCKSV", JdeDataType.String, 2),
        new JdeField("AYUKID", "AYUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("AYCTR", "AYCTR", JdeDataType.String, 6),
        new JdeField("AYNXTA", "AYNXTA", JdeDataType.Numeric),
        new JdeField("AYUPMJ", "AYUPMJ", JdeDataType.Numeric),
        new JdeField("AYUPMT", "AYUPMT", JdeDataType.Numeric),
        new JdeField("AYPID", "AYPID", JdeDataType.String, 20),
        new JdeField("AYUSER", "AYUSER", JdeDataType.String, 20),
        new JdeField("AYJOBN", "AYJOBN", JdeDataType.String, 20),
        new JdeField("AYIBAN", "AYIBAN", JdeDataType.String, 68),
        new JdeField("AYAN8BK", "AYAN8BK", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0030_0", "Primary Key on AYUKID", new[] { "AYUKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F0030_2", "Index on AYTNST, AYCBNK, AYBKTP", new[] { "AYTNST", "AYCBNK", "AYBKTP" }),
        new JdeIndex("F0030_3", "Index on AYBKTP, AYAID, AYMCU", new[] { "AYBKTP", "AYAID", "AYMCU" }),
        new JdeIndex("F0030_4", "Index on AYMCU, AYAID", new[] { "AYMCU", "AYAID" }),
        new JdeIndex("F0030_5", "Index on AYAN8, AYBKTP, AYTNST, AYCBNK", new[] { "AYAN8", "AYBKTP", "AYTNST", "AYCBNK" }),
        new JdeIndex("F0030_6", "Index on AYBKTP, AYAN8", new[] { "AYBKTP", "AYAN8" })
    };
}
