using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I851 - .
/// </summary>
public class F75I851 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BLUKID.
        /// </summary>
        public const string BLUKID = "BLUKID";

        /// <summary>
        /// BLI75GSTU.
        /// </summary>
        public const string BLI75GSTU = "BLI75GSTU";

        /// <summary>
        /// BLYEAR.
        /// </summary>
        public const string BLYEAR = "BLYEAR";

        /// <summary>
        /// BLI75BDLU.
        /// </summary>
        public const string BLI75BDLU = "BLI75BDLU";

        /// <summary>
        /// BLI75BLONM.
        /// </summary>
        public const string BLI75BLONM = "BLI75BLONM";

        /// <summary>
        /// BLDL01.
        /// </summary>
        public const string BLDL01 = "BLDL01";

        /// <summary>
        /// BLI75BLD.
        /// </summary>
        public const string BLI75BLD = "BLI75BLD";

        /// <summary>
        /// BLAEXD.
        /// </summary>
        public const string BLAEXD = "BLAEXD";

        /// <summary>
        /// BLI75OBLA.
        /// </summary>
        public const string BLI75OBLA = "BLI75OBLA";

        /// <summary>
        /// BLI75CBLA.
        /// </summary>
        public const string BLI75CBLA = "BLI75CBLA";

        /// <summary>
        /// BLI75CHGAT.
        /// </summary>
        public const string BLI75CHGAT = "BLI75CHGAT";

        /// <summary>
        /// BLI75BDREF.
        /// </summary>
        public const string BLI75BDREF = "BLI75BDREF";

        /// <summary>
        /// BLDEJ.
        /// </summary>
        public const string BLDEJ = "BLDEJ";

        /// <summary>
        /// BLALPH.
        /// </summary>
        public const string BLALPH = "BLALPH";

        /// <summary>
        /// BLADD1.
        /// </summary>
        public const string BLADD1 = "BLADD1";

        /// <summary>
        /// BLADD2.
        /// </summary>
        public const string BLADD2 = "BLADD2";

        /// <summary>
        /// BLUSER.
        /// </summary>
        public const string BLUSER = "BLUSER";

        /// <summary>
        /// BLPID.
        /// </summary>
        public const string BLPID = "BLPID";

        /// <summary>
        /// BLJOBN.
        /// </summary>
        public const string BLJOBN = "BLJOBN";

        /// <summary>
        /// BLUPMJ.
        /// </summary>
        public const string BLUPMJ = "BLUPMJ";

        /// <summary>
        /// BLUPMT.
        /// </summary>
        public const string BLUPMT = "BLUPMT";

        /// <summary>
        /// BLYFUTDT1.
        /// </summary>
        public const string BLYFUTDT1 = "BLYFUTDT1";

        /// <summary>
        /// BLFUT6.
        /// </summary>
        public const string BLFUT6 = "BLFUT6";

        /// <summary>
        /// BLYT04.
        /// </summary>
        public const string BLYT04 = "BLYT04";

        /// <summary>
        /// BLYFLAG.
        /// </summary>
        public const string BLYFLAG = "BLYFLAG";

        /// <summary>
        /// BLYNUM1.
        /// </summary>
        public const string BLYNUM1 = "BLYNUM1";
    }

    /// <inheritdoc />
    public override string TableName => "F75I851";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BLUKID", "BLUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("BLI75GSTU", "BLI75GSTU", JdeDataType.Numeric),
        new JdeField("BLYEAR", "BLYEAR", JdeDataType.Numeric),
        new JdeField("BLI75BDLU", "BLI75BDLU", JdeDataType.String, 60),
        new JdeField("BLI75BLONM", "BLI75BLONM", JdeDataType.String, 60),
        new JdeField("BLDL01", "BLDL01", JdeDataType.String, 60),
        new JdeField("BLI75BLD", "BLI75BLD", JdeDataType.Numeric),
        new JdeField("BLAEXD", "BLAEXD", JdeDataType.Numeric),
        new JdeField("BLI75OBLA", "BLI75OBLA", JdeDataType.Numeric),
        new JdeField("BLI75CBLA", "BLI75CBLA", JdeDataType.Numeric),
        new JdeField("BLI75CHGAT", "BLI75CHGAT", JdeDataType.Numeric),
        new JdeField("BLI75BDREF", "BLI75BDREF", JdeDataType.String, 60),
        new JdeField("BLDEJ", "BLDEJ", JdeDataType.Numeric),
        new JdeField("BLALPH", "BLALPH", JdeDataType.String, 80),
        new JdeField("BLADD1", "BLADD1", JdeDataType.String, 80),
        new JdeField("BLADD2", "BLADD2", JdeDataType.String, 80),
        new JdeField("BLUSER", "BLUSER", JdeDataType.String, 20),
        new JdeField("BLPID", "BLPID", JdeDataType.String, 20),
        new JdeField("BLJOBN", "BLJOBN", JdeDataType.String, 20),
        new JdeField("BLUPMJ", "BLUPMJ", JdeDataType.Numeric),
        new JdeField("BLUPMT", "BLUPMT", JdeDataType.Numeric),
        new JdeField("BLYFUTDT1", "BLYFUTDT1", JdeDataType.Numeric),
        new JdeField("BLFUT6", "BLFUT6", JdeDataType.String, 60),
        new JdeField("BLYT04", "BLYT04", JdeDataType.String, 2),
        new JdeField("BLYFLAG", "BLYFLAG", JdeDataType.String, 2),
        new JdeField("BLYNUM1", "BLYNUM1", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I851_0", "Primary Key on BLUKID", new[] { "BLUKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F75I851_2", "Index on BLI75BDLU, BLI75BDREF", new[] { "BLI75BDLU", "BLI75BDREF" })
    };
}
