using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F03B115 - .
/// </summary>
public class F03B115 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RSDCT.
        /// </summary>
        public const string RSDCT = "RSDCT";

        /// <summary>
        /// RSDOC.
        /// </summary>
        public const string RSDOC = "RSDOC";

        /// <summary>
        /// RSKCO.
        /// </summary>
        public const string RSKCO = "RSKCO";

        /// <summary>
        /// RSDGJ.
        /// </summary>
        public const string RSDGJ = "RSDGJ";

        /// <summary>
        /// RSJELN.
        /// </summary>
        public const string RSJELN = "RSJELN";

        /// <summary>
        /// RSLT.
        /// </summary>
        public const string RSLT = "RSLT";

        /// <summary>
        /// RSEXTL.
        /// </summary>
        public const string RSEXTL = "RSEXTL";

        /// <summary>
        /// RSLINN.
        /// </summary>
        public const string RSLINN = "RSLINN";

        /// <summary>
        /// RSRRSDT.
        /// </summary>
        public const string RSRRSDT = "RSRRSDT";

        /// <summary>
        /// RSRRSAR.
        /// </summary>
        public const string RSRRSAR = "RSRRSAR";

        /// <summary>
        /// RSRRFSAR.
        /// </summary>
        public const string RSRRFSAR = "RSRRFSAR";

        /// <summary>
        /// RSRRORA.
        /// </summary>
        public const string RSRRORA = "RSRRORA";

        /// <summary>
        /// RSRRFORA.
        /// </summary>
        public const string RSRRFORA = "RSRRFORA";

        /// <summary>
        /// RSU.
        /// </summary>
        public const string RSU = "RSU";

        /// <summary>
        /// RSUM.
        /// </summary>
        public const string RSUM = "RSUM";

        /// <summary>
        /// RSBCRC.
        /// </summary>
        public const string RSBCRC = "RSBCRC";

        /// <summary>
        /// RSCRCD.
        /// </summary>
        public const string RSCRCD = "RSCRCD";

        /// <summary>
        /// RSCRR.
        /// </summary>
        public const string RSCRR = "RSCRR";

        /// <summary>
        /// RSCRRM.
        /// </summary>
        public const string RSCRRM = "RSCRRM";

        /// <summary>
        /// RSUPMJ.
        /// </summary>
        public const string RSUPMJ = "RSUPMJ";

        /// <summary>
        /// RSUPMT.
        /// </summary>
        public const string RSUPMT = "RSUPMT";

        /// <summary>
        /// RSUSER.
        /// </summary>
        public const string RSUSER = "RSUSER";

        /// <summary>
        /// RSMKEY.
        /// </summary>
        public const string RSMKEY = "RSMKEY";

        /// <summary>
        /// RSPID.
        /// </summary>
        public const string RSPID = "RSPID";

        /// <summary>
        /// RSRRACH1.
        /// </summary>
        public const string RSRRACH1 = "RSRRACH1";

        /// <summary>
        /// RSRRACH2.
        /// </summary>
        public const string RSRRACH2 = "RSRRACH2";

        /// <summary>
        /// RSRRACH3.
        /// </summary>
        public const string RSRRACH3 = "RSRRACH3";

        /// <summary>
        /// RSRRADT1.
        /// </summary>
        public const string RSRRADT1 = "RSRRADT1";

        /// <summary>
        /// RSRRADT2.
        /// </summary>
        public const string RSRRADT2 = "RSRRADT2";

        /// <summary>
        /// RSRRADT3.
        /// </summary>
        public const string RSRRADT3 = "RSRRADT3";

        /// <summary>
        /// RSRRANU1.
        /// </summary>
        public const string RSRRANU1 = "RSRRANU1";

        /// <summary>
        /// RSRRANU2.
        /// </summary>
        public const string RSRRANU2 = "RSRRANU2";

        /// <summary>
        /// RSRRANU3.
        /// </summary>
        public const string RSRRANU3 = "RSRRANU3";

        /// <summary>
        /// RSRRAST1.
        /// </summary>
        public const string RSRRAST1 = "RSRRAST1";

        /// <summary>
        /// RSRRAST2.
        /// </summary>
        public const string RSRRAST2 = "RSRRAST2";

        /// <summary>
        /// RSRRAST3.
        /// </summary>
        public const string RSRRAST3 = "RSRRAST3";

        /// <summary>
        /// RSRRC.
        /// </summary>
        public const string RSRRC = "RSRRC";
    }

    /// <inheritdoc />
    public override string TableName => "F03B115";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RSDCT", "RSDCT", JdeDataType.String, 4, true, true),
        new JdeField("RSDOC", "RSDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("RSKCO", "RSKCO", JdeDataType.String, 10, true, true),
        new JdeField("RSDGJ", "RSDGJ", JdeDataType.Numeric, null, true, true),
        new JdeField("RSJELN", "RSJELN", JdeDataType.Numeric, null, true, true),
        new JdeField("RSLT", "RSLT", JdeDataType.String, 4, true, true),
        new JdeField("RSEXTL", "RSEXTL", JdeDataType.String, 4, true, true),
        new JdeField("RSLINN", "RSLINN", JdeDataType.Numeric, null, true, true),
        new JdeField("RSRRSDT", "RSRRSDT", JdeDataType.Numeric),
        new JdeField("RSRRSAR", "RSRRSAR", JdeDataType.Numeric),
        new JdeField("RSRRFSAR", "RSRRFSAR", JdeDataType.Numeric),
        new JdeField("RSRRORA", "RSRRORA", JdeDataType.Numeric),
        new JdeField("RSRRFORA", "RSRRFORA", JdeDataType.Numeric),
        new JdeField("RSU", "RSU", JdeDataType.Numeric),
        new JdeField("RSUM", "RSUM", JdeDataType.String, 4),
        new JdeField("RSBCRC", "RSBCRC", JdeDataType.String, 6),
        new JdeField("RSCRCD", "RSCRCD", JdeDataType.String, 6),
        new JdeField("RSCRR", "RSCRR", JdeDataType.Numeric),
        new JdeField("RSCRRM", "RSCRRM", JdeDataType.String, 2),
        new JdeField("RSUPMJ", "RSUPMJ", JdeDataType.Numeric),
        new JdeField("RSUPMT", "RSUPMT", JdeDataType.Numeric),
        new JdeField("RSUSER", "RSUSER", JdeDataType.String, 20),
        new JdeField("RSMKEY", "RSMKEY", JdeDataType.String, 30),
        new JdeField("RSPID", "RSPID", JdeDataType.String, 20),
        new JdeField("RSRRACH1", "RSRRACH1", JdeDataType.String, 2),
        new JdeField("RSRRACH2", "RSRRACH2", JdeDataType.String, 2),
        new JdeField("RSRRACH3", "RSRRACH3", JdeDataType.String, 2),
        new JdeField("RSRRADT1", "RSRRADT1", JdeDataType.Numeric),
        new JdeField("RSRRADT2", "RSRRADT2", JdeDataType.Numeric),
        new JdeField("RSRRADT3", "RSRRADT3", JdeDataType.Numeric),
        new JdeField("RSRRANU1", "RSRRANU1", JdeDataType.Numeric),
        new JdeField("RSRRANU2", "RSRRANU2", JdeDataType.Numeric),
        new JdeField("RSRRANU3", "RSRRANU3", JdeDataType.Numeric),
        new JdeField("RSRRAST1", "RSRRAST1", JdeDataType.String, 160),
        new JdeField("RSRRAST2", "RSRRAST2", JdeDataType.String, 160),
        new JdeField("RSRRAST3", "RSRRAST3", JdeDataType.String, 160),
        new JdeField("RSRRC", "RSRRC", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F03B115_0", "Primary Key on RSDCT, RSDOC, RSKCO, RSDGJ, RSJELN, RSLT, RSEXTL, RSLINN", new[] { "RSDCT", "RSDOC", "RSKCO", "RSDGJ", "RSJELN", "RSLT", "RSEXTL", "RSLINN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F03B115_2", "Index on RSDCT, RSDOC, RSKCO, RSDGJ, RSJELN, RSLT, RSEXTL", new[] { "RSDCT", "RSDOC", "RSKCO", "RSDGJ", "RSJELN", "RSLT", "RSEXTL" }),
        new JdeIndex("F03B115_3", "Index on RSDCT, RSDOC, RSKCO, RSDGJ, RSJELN, RSLT, RSEXTL, SYS_NC00038$", new[] { "RSDCT", "RSDOC", "RSKCO", "RSDGJ", "RSJELN", "RSLT", "RSEXTL", "SYS_NC00038$" })
    };
}
