using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F085537W - .
/// </summary>
public class F085537W : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// XBAN8.
        /// </summary>
        public const string XBAN8 = "XBAN8";

        /// <summary>
        /// XBPAN8.
        /// </summary>
        public const string XBPAN8 = "XBPAN8";

        /// <summary>
        /// XBMLNM.
        /// </summary>
        public const string XBMLNM = "XBMLNM";

        /// <summary>
        /// XBDBEN.
        /// </summary>
        public const string XBDBEN = "XBDBEN";

        /// <summary>
        /// XBRELA.
        /// </summary>
        public const string XBRELA = "XBRELA";

        /// <summary>
        /// XBPLAN.
        /// </summary>
        public const string XBPLAN = "XBPLAN";

        /// <summary>
        /// XBAOPT.
        /// </summary>
        public const string XBAOPT = "XBAOPT";

        /// <summary>
        /// XBEFT.
        /// </summary>
        public const string XBEFT = "XBEFT";

        /// <summary>
        /// XBEFTE.
        /// </summary>
        public const string XBEFTE = "XBEFTE";

        /// <summary>
        /// XBPCP#.
        /// </summary>
        public const string XBPCP_ = "XBPCP#";

        /// <summary>
        /// XBPERC.
        /// </summary>
        public const string XBPERC = "XBPERC";

        /// <summary>
        /// XBSECPERC.
        /// </summary>
        public const string XBSECPERC = "XBSECPERC";

        /// <summary>
        /// XBNEWPERC.
        /// </summary>
        public const string XBNEWPERC = "XBNEWPERC";

        /// <summary>
        /// XBNSECPERC.
        /// </summary>
        public const string XBNSECPERC = "XBNSECPERC";

        /// <summary>
        /// XBPCPVST.
        /// </summary>
        public const string XBPCPVST = "XBPCPVST";

        /// <summary>
        /// XBUSER.
        /// </summary>
        public const string XBUSER = "XBUSER";

        /// <summary>
        /// XBPID.
        /// </summary>
        public const string XBPID = "XBPID";

        /// <summary>
        /// XBJOBN.
        /// </summary>
        public const string XBJOBN = "XBJOBN";

        /// <summary>
        /// XBUPMJ.
        /// </summary>
        public const string XBUPMJ = "XBUPMJ";

        /// <summary>
        /// XBUPMT.
        /// </summary>
        public const string XBUPMT = "XBUPMT";

        /// <summary>
        /// XBCCAI.
        /// </summary>
        public const string XBCCAI = "XBCCAI";
    }

    /// <inheritdoc />
    public override string TableName => "F085537W";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("XBAN8", "XBAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("XBPAN8", "XBPAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("XBMLNM", "XBMLNM", JdeDataType.String, 80),
        new JdeField("XBDBEN", "XBDBEN", JdeDataType.String, 2, true, true),
        new JdeField("XBRELA", "XBRELA", JdeDataType.String, 2),
        new JdeField("XBPLAN", "XBPLAN", JdeDataType.String, 16, true, true),
        new JdeField("XBAOPT", "XBAOPT", JdeDataType.String, 6, true, true),
        new JdeField("XBEFT", "XBEFT", JdeDataType.Numeric),
        new JdeField("XBEFTE", "XBEFTE", JdeDataType.Numeric),
        new JdeField("XBPCP#", "XBPCP#", JdeDataType.String, 40),
        new JdeField("XBPERC", "XBPERC", JdeDataType.Numeric),
        new JdeField("XBSECPERC", "XBSECPERC", JdeDataType.Numeric),
        new JdeField("XBNEWPERC", "XBNEWPERC", JdeDataType.Numeric),
        new JdeField("XBNSECPERC", "XBNSECPERC", JdeDataType.Numeric),
        new JdeField("XBPCPVST", "XBPCPVST", JdeDataType.String, 2),
        new JdeField("XBUSER", "XBUSER", JdeDataType.String, 20),
        new JdeField("XBPID", "XBPID", JdeDataType.String, 20),
        new JdeField("XBJOBN", "XBJOBN", JdeDataType.String, 20),
        new JdeField("XBUPMJ", "XBUPMJ", JdeDataType.Numeric),
        new JdeField("XBUPMT", "XBUPMT", JdeDataType.Numeric),
        new JdeField("XBCCAI", "XBCCAI", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F085537W_0", "Primary Key on XBAN8, XBPAN8, XBDBEN, XBPLAN, XBAOPT", new[] { "XBAN8", "XBPAN8", "XBDBEN", "XBPLAN", "XBAOPT" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F085537W_2", "Index on XBAN8, XBPLAN, XBAOPT", new[] { "XBAN8", "XBPLAN", "XBAOPT" }),
        new JdeIndex("F085537W_3", "Index on XBAN8, XBPAN8", new[] { "XBAN8", "XBPAN8" })
    };
}
