using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74Y015 - .
/// </summary>
public class F74Y015 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// YLJOBS.
        /// </summary>
        public const string YLJOBS = "YLJOBS";

        /// <summary>
        /// YLKCO.
        /// </summary>
        public const string YLKCO = "YLKCO";

        /// <summary>
        /// YLDCT.
        /// </summary>
        public const string YLDCT = "YLDCT";

        /// <summary>
        /// YLDOC.
        /// </summary>
        public const string YLDOC = "YLDOC";

        /// <summary>
        /// YLSFX.
        /// </summary>
        public const string YLSFX = "YLSFX";

        /// <summary>
        /// YLY74TPUL.
        /// </summary>
        public const string YLY74TPUL = "YLY74TPUL";

        /// <summary>
        /// YLY74ECODE.
        /// </summary>
        public const string YLY74ECODE = "YLY74ECODE";

        /// <summary>
        /// YLY74DEDT.
        /// </summary>
        public const string YLY74DEDT = "YLY74DEDT";

        /// <summary>
        /// YLTX2.
        /// </summary>
        public const string YLTX2 = "YLTX2";

        /// <summary>
        /// YLTAX.
        /// </summary>
        public const string YLTAX = "YLTAX";

        /// <summary>
        /// YLAN8.
        /// </summary>
        public const string YLAN8 = "YLAN8";

        /// <summary>
        /// YLALPH.
        /// </summary>
        public const string YLALPH = "YLALPH";

        /// <summary>
        /// YLDGJ.
        /// </summary>
        public const string YLDGJ = "YLDGJ";

        /// <summary>
        /// YLCTR.
        /// </summary>
        public const string YLCTR = "YLCTR";

        /// <summary>
        /// YLY74PYM.
        /// </summary>
        public const string YLY74PYM = "YLY74PYM";

        /// <summary>
        /// YLY74TXTP.
        /// </summary>
        public const string YLY74TXTP = "YLY74TXTP";

        /// <summary>
        /// YLY74OPTY.
        /// </summary>
        public const string YLY74OPTY = "YLY74OPTY";

        /// <summary>
        /// YLICUT.
        /// </summary>
        public const string YLICUT = "YLICUT";

        /// <summary>
        /// YLTXA1.
        /// </summary>
        public const string YLTXA1 = "YLTXA1";

        /// <summary>
        /// YLAG.
        /// </summary>
        public const string YLAG = "YLAG";

        /// <summary>
        /// YLATXA.
        /// </summary>
        public const string YLATXA = "YLATXA";

        /// <summary>
        /// YLSTAM.
        /// </summary>
        public const string YLSTAM = "YLSTAM";

        /// <summary>
        /// YLATXN.
        /// </summary>
        public const string YLATXN = "YLATXN";

        /// <summary>
        /// YLY74RDTP.
        /// </summary>
        public const string YLY74RDTP = "YLY74RDTP";

        /// <summary>
        /// YLY74TVAT.
        /// </summary>
        public const string YLY74TVAT = "YLY74TVAT";

        /// <summary>
        /// YLY74TAXT.
        /// </summary>
        public const string YLY74TAXT = "YLY74TAXT";

        /// <summary>
        /// YLGFL1.
        /// </summary>
        public const string YLGFL1 = "YLGFL1";

        /// <summary>
        /// YLODOC.
        /// </summary>
        public const string YLODOC = "YLODOC";

        /// <summary>
        /// YLODCT.
        /// </summary>
        public const string YLODCT = "YLODCT";

        /// <summary>
        /// YLOKCO.
        /// </summary>
        public const string YLOKCO = "YLOKCO";

        /// <summary>
        /// YLY74OAA.
        /// </summary>
        public const string YLY74OAA = "YLY74OAA";

        /// <summary>
        /// YLY74OATXA.
        /// </summary>
        public const string YLY74OATXA = "YLY74OATXA";

        /// <summary>
        /// YLY74OSTAM.
        /// </summary>
        public const string YLY74OSTAM = "YLY74OSTAM";

        /// <summary>
        /// YLY74OATXN.
        /// </summary>
        public const string YLY74OATXN = "YLY74OATXN";

        /// <summary>
        /// YLY74CTID.
        /// </summary>
        public const string YLY74CTID = "YLY74CTID";

        /// <summary>
        /// YLUPMJ.
        /// </summary>
        public const string YLUPMJ = "YLUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F74Y015";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("YLJOBS", "YLJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("YLKCO", "YLKCO", JdeDataType.String, 10, true, true),
        new JdeField("YLDCT", "YLDCT", JdeDataType.String, 4, true, true),
        new JdeField("YLDOC", "YLDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("YLSFX", "YLSFX", JdeDataType.String, 6, true, true),
        new JdeField("YLY74TPUL", "YLY74TPUL", JdeDataType.String, 2),
        new JdeField("YLY74ECODE", "YLY74ECODE", JdeDataType.Numeric),
        new JdeField("YLY74DEDT", "YLY74DEDT", JdeDataType.Numeric),
        new JdeField("YLTX2", "YLTX2", JdeDataType.String, 40),
        new JdeField("YLTAX", "YLTAX", JdeDataType.String, 40),
        new JdeField("YLAN8", "YLAN8", JdeDataType.Numeric),
        new JdeField("YLALPH", "YLALPH", JdeDataType.String, 80),
        new JdeField("YLDGJ", "YLDGJ", JdeDataType.Numeric),
        new JdeField("YLCTR", "YLCTR", JdeDataType.String, 6),
        new JdeField("YLY74PYM", "YLY74PYM", JdeDataType.Numeric),
        new JdeField("YLY74TXTP", "YLY74TXTP", JdeDataType.String, 2),
        new JdeField("YLY74OPTY", "YLY74OPTY", JdeDataType.String, 2),
        new JdeField("YLICUT", "YLICUT", JdeDataType.String, 4),
        new JdeField("YLTXA1", "YLTXA1", JdeDataType.String, 20),
        new JdeField("YLAG", "YLAG", JdeDataType.Numeric),
        new JdeField("YLATXA", "YLATXA", JdeDataType.Numeric),
        new JdeField("YLSTAM", "YLSTAM", JdeDataType.Numeric),
        new JdeField("YLATXN", "YLATXN", JdeDataType.Numeric),
        new JdeField("YLY74RDTP", "YLY74RDTP", JdeDataType.String, 2),
        new JdeField("YLY74TVAT", "YLY74TVAT", JdeDataType.Numeric),
        new JdeField("YLY74TAXT", "YLY74TAXT", JdeDataType.Numeric),
        new JdeField("YLGFL1", "YLGFL1", JdeDataType.String, 2),
        new JdeField("YLODOC", "YLODOC", JdeDataType.Numeric),
        new JdeField("YLODCT", "YLODCT", JdeDataType.String, 4),
        new JdeField("YLOKCO", "YLOKCO", JdeDataType.String, 10),
        new JdeField("YLY74OAA", "YLY74OAA", JdeDataType.Numeric),
        new JdeField("YLY74OATXA", "YLY74OATXA", JdeDataType.Numeric),
        new JdeField("YLY74OSTAM", "YLY74OSTAM", JdeDataType.Numeric),
        new JdeField("YLY74OATXN", "YLY74OATXN", JdeDataType.Numeric),
        new JdeField("YLY74CTID", "YLY74CTID", JdeDataType.Numeric),
        new JdeField("YLUPMJ", "YLUPMJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74Y015_0", "Primary Key on YLJOBS, YLKCO, YLDCT, YLDOC, YLSFX", new[] { "YLJOBS", "YLKCO", "YLDCT", "YLDOC", "YLSFX" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F74Y015_2", "Index on YLODOC, YLODCT, YLOKCO", new[] { "YLODOC", "YLODCT", "YLOKCO" }),
        new JdeIndex("F74Y015_3", "Index on YLY74CTID", new[] { "YLY74CTID" })
    };
}
