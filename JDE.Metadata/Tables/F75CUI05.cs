using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75CUI05 - .
/// </summary>
public class F75CUI05 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// MPCO.
        /// </summary>
        public const string MPCO = "MPCO";

        /// <summary>
        /// MPC75ACCYR.
        /// </summary>
        public const string MPC75ACCYR = "MPC75ACCYR";

        /// <summary>
        /// MPPN.
        /// </summary>
        public const string MPPN = "MPPN";

        /// <summary>
        /// MPFLAG.
        /// </summary>
        public const string MPFLAG = "MPFLAG";

        /// <summary>
        /// MPC75LNID.
        /// </summary>
        public const string MPC75LNID = "MPC75LNID";

        /// <summary>
        /// MPAN8.
        /// </summary>
        public const string MPAN8 = "MPAN8";

        /// <summary>
        /// MPDGJ.
        /// </summary>
        public const string MPDGJ = "MPDGJ";

        /// <summary>
        /// MPDOC.
        /// </summary>
        public const string MPDOC = "MPDOC";

        /// <summary>
        /// MPDCT.
        /// </summary>
        public const string MPDCT = "MPDCT";

        /// <summary>
        /// MPSFX.
        /// </summary>
        public const string MPSFX = "MPSFX";

        /// <summary>
        /// MPC75XMLE1.
        /// </summary>
        public const string MPC75XMLE1 = "MPC75XMLE1";

        /// <summary>
        /// MPC75XMLE2.
        /// </summary>
        public const string MPC75XMLE2 = "MPC75XMLE2";

        /// <summary>
        /// MPC75XMLE3.
        /// </summary>
        public const string MPC75XMLE3 = "MPC75XMLE3";

        /// <summary>
        /// MPC75XMLE4.
        /// </summary>
        public const string MPC75XMLE4 = "MPC75XMLE4";

        /// <summary>
        /// MPC75XMLE5.
        /// </summary>
        public const string MPC75XMLE5 = "MPC75XMLE5";

        /// <summary>
        /// MPC75XMLE6.
        /// </summary>
        public const string MPC75XMLE6 = "MPC75XMLE6";

        /// <summary>
        /// MPC75XMLE7.
        /// </summary>
        public const string MPC75XMLE7 = "MPC75XMLE7";

        /// <summary>
        /// MPC75XMLE8.
        /// </summary>
        public const string MPC75XMLE8 = "MPC75XMLE8";

        /// <summary>
        /// MPC75XMLE9.
        /// </summary>
        public const string MPC75XMLE9 = "MPC75XMLE9";

        /// <summary>
        /// MPC75XML10.
        /// </summary>
        public const string MPC75XML10 = "MPC75XML10";

        /// <summary>
        /// MPC75XML11.
        /// </summary>
        public const string MPC75XML11 = "MPC75XML11";

        /// <summary>
        /// MPC75XML12.
        /// </summary>
        public const string MPC75XML12 = "MPC75XML12";

        /// <summary>
        /// MPC75XML13.
        /// </summary>
        public const string MPC75XML13 = "MPC75XML13";

        /// <summary>
        /// MPC75XML14.
        /// </summary>
        public const string MPC75XML14 = "MPC75XML14";

        /// <summary>
        /// MPC75XML15.
        /// </summary>
        public const string MPC75XML15 = "MPC75XML15";

        /// <summary>
        /// MPC75XML16.
        /// </summary>
        public const string MPC75XML16 = "MPC75XML16";

        /// <summary>
        /// MPC75XML17.
        /// </summary>
        public const string MPC75XML17 = "MPC75XML17";

        /// <summary>
        /// MPC75XML18.
        /// </summary>
        public const string MPC75XML18 = "MPC75XML18";

        /// <summary>
        /// MPC75XML19.
        /// </summary>
        public const string MPC75XML19 = "MPC75XML19";

        /// <summary>
        /// MPC75XML20.
        /// </summary>
        public const string MPC75XML20 = "MPC75XML20";

        /// <summary>
        /// MPC75XML21.
        /// </summary>
        public const string MPC75XML21 = "MPC75XML21";

        /// <summary>
        /// MPC75XML22.
        /// </summary>
        public const string MPC75XML22 = "MPC75XML22";

        /// <summary>
        /// MPC75XML23.
        /// </summary>
        public const string MPC75XML23 = "MPC75XML23";

        /// <summary>
        /// MPC75XML24.
        /// </summary>
        public const string MPC75XML24 = "MPC75XML24";

        /// <summary>
        /// MPC75XML25.
        /// </summary>
        public const string MPC75XML25 = "MPC75XML25";

        /// <summary>
        /// MPC75XML26.
        /// </summary>
        public const string MPC75XML26 = "MPC75XML26";

        /// <summary>
        /// MPC75XML27.
        /// </summary>
        public const string MPC75XML27 = "MPC75XML27";

        /// <summary>
        /// MPC75XML28.
        /// </summary>
        public const string MPC75XML28 = "MPC75XML28";

        /// <summary>
        /// MPC75XML29.
        /// </summary>
        public const string MPC75XML29 = "MPC75XML29";

        /// <summary>
        /// MPC75XML30.
        /// </summary>
        public const string MPC75XML30 = "MPC75XML30";

        /// <summary>
        /// MPC75XML31.
        /// </summary>
        public const string MPC75XML31 = "MPC75XML31";

        /// <summary>
        /// MPC75XML32.
        /// </summary>
        public const string MPC75XML32 = "MPC75XML32";

        /// <summary>
        /// MPC75XML33.
        /// </summary>
        public const string MPC75XML33 = "MPC75XML33";

        /// <summary>
        /// MPC75XML34.
        /// </summary>
        public const string MPC75XML34 = "MPC75XML34";

        /// <summary>
        /// MPC75XML35.
        /// </summary>
        public const string MPC75XML35 = "MPC75XML35";

        /// <summary>
        /// MPPID.
        /// </summary>
        public const string MPPID = "MPPID";

        /// <summary>
        /// MPUPMJ.
        /// </summary>
        public const string MPUPMJ = "MPUPMJ";

        /// <summary>
        /// MPUPMT.
        /// </summary>
        public const string MPUPMT = "MPUPMT";

        /// <summary>
        /// MPUSER.
        /// </summary>
        public const string MPUSER = "MPUSER";

        /// <summary>
        /// MPJOBN.
        /// </summary>
        public const string MPJOBN = "MPJOBN";

        /// <summary>
        /// MPFUT1.
        /// </summary>
        public const string MPFUT1 = "MPFUT1";

        /// <summary>
        /// MPFUT2.
        /// </summary>
        public const string MPFUT2 = "MPFUT2";

        /// <summary>
        /// MPFUT3.
        /// </summary>
        public const string MPFUT3 = "MPFUT3";

        /// <summary>
        /// MPFUTCHAR1.
        /// </summary>
        public const string MPFUTCHAR1 = "MPFUTCHAR1";

        /// <summary>
        /// MPCMDT.
        /// </summary>
        public const string MPCMDT = "MPCMDT";
    }

    /// <inheritdoc />
    public override string TableName => "F75CUI05";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("MPCO", "MPCO", JdeDataType.String, 10, true, true),
        new JdeField("MPC75ACCYR", "MPC75ACCYR", JdeDataType.Numeric, null, true, true),
        new JdeField("MPPN", "MPPN", JdeDataType.Numeric, null, true, true),
        new JdeField("MPFLAG", "MPFLAG", JdeDataType.String, 2, true, true),
        new JdeField("MPC75LNID", "MPC75LNID", JdeDataType.Numeric, null, true, true),
        new JdeField("MPAN8", "MPAN8", JdeDataType.Numeric),
        new JdeField("MPDGJ", "MPDGJ", JdeDataType.Numeric),
        new JdeField("MPDOC", "MPDOC", JdeDataType.Numeric),
        new JdeField("MPDCT", "MPDCT", JdeDataType.String, 4),
        new JdeField("MPSFX", "MPSFX", JdeDataType.String, 6),
        new JdeField("MPC75XMLE1", "MPC75XMLE1", JdeDataType.String, 120),
        new JdeField("MPC75XMLE2", "MPC75XMLE2", JdeDataType.String, 120),
        new JdeField("MPC75XMLE3", "MPC75XMLE3", JdeDataType.String, 120),
        new JdeField("MPC75XMLE4", "MPC75XMLE4", JdeDataType.String, 120),
        new JdeField("MPC75XMLE5", "MPC75XMLE5", JdeDataType.String, 120),
        new JdeField("MPC75XMLE6", "MPC75XMLE6", JdeDataType.String, 120),
        new JdeField("MPC75XMLE7", "MPC75XMLE7", JdeDataType.String, 120),
        new JdeField("MPC75XMLE8", "MPC75XMLE8", JdeDataType.String, 120),
        new JdeField("MPC75XMLE9", "MPC75XMLE9", JdeDataType.String, 120),
        new JdeField("MPC75XML10", "MPC75XML10", JdeDataType.String, 120),
        new JdeField("MPC75XML11", "MPC75XML11", JdeDataType.String, 120),
        new JdeField("MPC75XML12", "MPC75XML12", JdeDataType.String, 120),
        new JdeField("MPC75XML13", "MPC75XML13", JdeDataType.String, 120),
        new JdeField("MPC75XML14", "MPC75XML14", JdeDataType.String, 120),
        new JdeField("MPC75XML15", "MPC75XML15", JdeDataType.String, 120),
        new JdeField("MPC75XML16", "MPC75XML16", JdeDataType.String, 120),
        new JdeField("MPC75XML17", "MPC75XML17", JdeDataType.String, 120),
        new JdeField("MPC75XML18", "MPC75XML18", JdeDataType.String, 120),
        new JdeField("MPC75XML19", "MPC75XML19", JdeDataType.String, 120),
        new JdeField("MPC75XML20", "MPC75XML20", JdeDataType.String, 120),
        new JdeField("MPC75XML21", "MPC75XML21", JdeDataType.String, 120),
        new JdeField("MPC75XML22", "MPC75XML22", JdeDataType.String, 120),
        new JdeField("MPC75XML23", "MPC75XML23", JdeDataType.String, 120),
        new JdeField("MPC75XML24", "MPC75XML24", JdeDataType.String, 120),
        new JdeField("MPC75XML25", "MPC75XML25", JdeDataType.String, 120),
        new JdeField("MPC75XML26", "MPC75XML26", JdeDataType.String, 120),
        new JdeField("MPC75XML27", "MPC75XML27", JdeDataType.String, 120),
        new JdeField("MPC75XML28", "MPC75XML28", JdeDataType.String, 120),
        new JdeField("MPC75XML29", "MPC75XML29", JdeDataType.String, 120),
        new JdeField("MPC75XML30", "MPC75XML30", JdeDataType.String, 120),
        new JdeField("MPC75XML31", "MPC75XML31", JdeDataType.String, 120),
        new JdeField("MPC75XML32", "MPC75XML32", JdeDataType.String, 120),
        new JdeField("MPC75XML33", "MPC75XML33", JdeDataType.String, 120),
        new JdeField("MPC75XML34", "MPC75XML34", JdeDataType.String, 120),
        new JdeField("MPC75XML35", "MPC75XML35", JdeDataType.String, 120),
        new JdeField("MPPID", "MPPID", JdeDataType.String, 20),
        new JdeField("MPUPMJ", "MPUPMJ", JdeDataType.Numeric),
        new JdeField("MPUPMT", "MPUPMT", JdeDataType.Numeric),
        new JdeField("MPUSER", "MPUSER", JdeDataType.String, 20),
        new JdeField("MPJOBN", "MPJOBN", JdeDataType.String, 20),
        new JdeField("MPFUT1", "MPFUT1", JdeDataType.Numeric),
        new JdeField("MPFUT2", "MPFUT2", JdeDataType.Numeric),
        new JdeField("MPFUT3", "MPFUT3", JdeDataType.String, 60),
        new JdeField("MPFUTCHAR1", "MPFUTCHAR1", JdeDataType.String, 2),
        new JdeField("MPCMDT", "MPCMDT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75CUI05_0", "Primary Key on MPCO, MPC75ACCYR, MPPN, MPFLAG, MPC75LNID", new[] { "MPCO", "MPC75ACCYR", "MPPN", "MPFLAG", "MPC75LNID" }, isUnique: true, isPrimaryKey: true)
    };
}
