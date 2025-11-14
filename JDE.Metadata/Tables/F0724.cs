using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0724 - .
/// </summary>
public class F0724 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// YSPRTR.
        /// </summary>
        public const string YSPRTR = "YSPRTR";

        /// <summary>
        /// YSUKID.
        /// </summary>
        public const string YSUKID = "YSUKID";

        /// <summary>
        /// YSDWK.
        /// </summary>
        public const string YSDWK = "YSDWK";

        /// <summary>
        /// YSAN8.
        /// </summary>
        public const string YSAN8 = "YSAN8";

        /// <summary>
        /// YSGICU.
        /// </summary>
        public const string YSGICU = "YSGICU";

        /// <summary>
        /// YSPDBA.
        /// </summary>
        public const string YSPDBA = "YSPDBA";

        /// <summary>
        /// YSPTAX.
        /// </summary>
        public const string YSPTAX = "YSPTAX";

        /// <summary>
        /// YSFRTY.
        /// </summary>
        public const string YSFRTY = "YSFRTY";

        /// <summary>
        /// YSB2RT.
        /// </summary>
        public const string YSB2RT = "YSB2RT";

        /// <summary>
        /// YSBDA.
        /// </summary>
        public const string YSBDA = "YSBDA";

        /// <summary>
        /// YSMCU.
        /// </summary>
        public const string YSMCU = "YSMCU";

        /// <summary>
        /// YSOBJ.
        /// </summary>
        public const string YSOBJ = "YSOBJ";

        /// <summary>
        /// YSSUB.
        /// </summary>
        public const string YSSUB = "YSSUB";

        /// <summary>
        /// YSSBL.
        /// </summary>
        public const string YSSBL = "YSSBL";

        /// <summary>
        /// YSSBLT.
        /// </summary>
        public const string YSSBLT = "YSSBLT";

        /// <summary>
        /// YSBRDS.
        /// </summary>
        public const string YSBRDS = "YSBRDS";

        /// <summary>
        /// YSWR01.
        /// </summary>
        public const string YSWR01 = "YSWR01";

        /// <summary>
        /// YSPHRW.
        /// </summary>
        public const string YSPHRW = "YSPHRW";

        /// <summary>
        /// YSDEDM.
        /// </summary>
        public const string YSDEDM = "YSDEDM";

        /// <summary>
        /// YSUPMJ.
        /// </summary>
        public const string YSUPMJ = "YSUPMJ";

        /// <summary>
        /// YSUPMT.
        /// </summary>
        public const string YSUPMT = "YSUPMT";

        /// <summary>
        /// YSPID.
        /// </summary>
        public const string YSPID = "YSPID";

        /// <summary>
        /// YSJOBN.
        /// </summary>
        public const string YSJOBN = "YSJOBN";

        /// <summary>
        /// YSUSER.
        /// </summary>
        public const string YSUSER = "YSUSER";
    }

    /// <inheritdoc />
    public override string TableName => "F0724";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("YSPRTR", "YSPRTR", JdeDataType.Numeric, null, true, true),
        new JdeField("YSUKID", "YSUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("YSDWK", "YSDWK", JdeDataType.Numeric),
        new JdeField("YSAN8", "YSAN8", JdeDataType.Numeric),
        new JdeField("YSGICU", "YSGICU", JdeDataType.Numeric, null, true, true),
        new JdeField("YSPDBA", "YSPDBA", JdeDataType.Numeric),
        new JdeField("YSPTAX", "YSPTAX", JdeDataType.String, 4),
        new JdeField("YSFRTY", "YSFRTY", JdeDataType.String, 4),
        new JdeField("YSB2RT", "YSB2RT", JdeDataType.Numeric),
        new JdeField("YSBDA", "YSBDA", JdeDataType.Numeric),
        new JdeField("YSMCU", "YSMCU", JdeDataType.String, 24),
        new JdeField("YSOBJ", "YSOBJ", JdeDataType.String, 12),
        new JdeField("YSSUB", "YSSUB", JdeDataType.String, 16),
        new JdeField("YSSBL", "YSSBL", JdeDataType.String, 16),
        new JdeField("YSSBLT", "YSSBLT", JdeDataType.String, 2),
        new JdeField("YSBRDS", "YSBRDS", JdeDataType.String, 2),
        new JdeField("YSWR01", "YSWR01", JdeDataType.String, 8),
        new JdeField("YSPHRW", "YSPHRW", JdeDataType.Numeric),
        new JdeField("YSDEDM", "YSDEDM", JdeDataType.String, 2),
        new JdeField("YSUPMJ", "YSUPMJ", JdeDataType.Numeric),
        new JdeField("YSUPMT", "YSUPMT", JdeDataType.Numeric),
        new JdeField("YSPID", "YSPID", JdeDataType.String, 20),
        new JdeField("YSJOBN", "YSJOBN", JdeDataType.String, 20),
        new JdeField("YSUSER", "YSUSER", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0724_0", "Primary Key on YSGICU, YSPRTR, YSUKID", new[] { "YSGICU", "YSPRTR", "YSUKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F0724_2", "Index on YSAN8, YSPRTR, YSUKID, YSGICU", new[] { "YSAN8", "YSPRTR", "YSUKID", "YSGICU" })
    };
}
