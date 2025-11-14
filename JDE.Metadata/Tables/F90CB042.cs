using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F90CB042 - .
/// </summary>
public class F90CB042 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// QQQQ8.
        /// </summary>
        public const string QQQQ8 = "QQQQ8";

        /// <summary>
        /// QQACTIND.
        /// </summary>
        public const string QQACTIND = "QQACTIND";

        /// <summary>
        /// QQQL8.
        /// </summary>
        public const string QQQL8 = "QQQL8";

        /// <summary>
        /// QQQLQT.
        /// </summary>
        public const string QQQLQT = "QQQLQT";

        /// <summary>
        /// QQQQSE.
        /// </summary>
        public const string QQQQSE = "QQQQSE";

        /// <summary>
        /// QQQLWV.
        /// </summary>
        public const string QQQLWV = "QQQLWV";

        /// <summary>
        /// QQQLQV.
        /// </summary>
        public const string QQQLQV = "QQQLQV";

        /// <summary>
        /// QQEXVAR0.
        /// </summary>
        public const string QQEXVAR0 = "QQEXVAR0";

        /// <summary>
        /// QQEXVAR1.
        /// </summary>
        public const string QQEXVAR1 = "QQEXVAR1";

        /// <summary>
        /// QQEXVAR2.
        /// </summary>
        public const string QQEXVAR2 = "QQEXVAR2";

        /// <summary>
        /// QQEXVAR3.
        /// </summary>
        public const string QQEXVAR3 = "QQEXVAR3";

        /// <summary>
        /// QQEXVAR4.
        /// </summary>
        public const string QQEXVAR4 = "QQEXVAR4";

        /// <summary>
        /// QQEXVAR5.
        /// </summary>
        public const string QQEXVAR5 = "QQEXVAR5";

        /// <summary>
        /// QQEXVAR6.
        /// </summary>
        public const string QQEXVAR6 = "QQEXVAR6";

        /// <summary>
        /// QQEXVAR7.
        /// </summary>
        public const string QQEXVAR7 = "QQEXVAR7";

        /// <summary>
        /// QQEXDT0.
        /// </summary>
        public const string QQEXDT0 = "QQEXDT0";

        /// <summary>
        /// QQEXDT1.
        /// </summary>
        public const string QQEXDT1 = "QQEXDT1";

        /// <summary>
        /// QQEXDT2.
        /// </summary>
        public const string QQEXDT2 = "QQEXDT2";

        /// <summary>
        /// QQENTDBY.
        /// </summary>
        public const string QQENTDBY = "QQENTDBY";

        /// <summary>
        /// QQMODB.
        /// </summary>
        public const string QQMODB = "QQMODB";

        /// <summary>
        /// QQSTSUDT.
        /// </summary>
        public const string QQSTSUDT = "QQSTSUDT";

        /// <summary>
        /// QQEDATE.
        /// </summary>
        public const string QQEDATE = "QQEDATE";

        /// <summary>
        /// QQMDATE.
        /// </summary>
        public const string QQMDATE = "QQMDATE";

        /// <summary>
        /// QQUSER.
        /// </summary>
        public const string QQUSER = "QQUSER";

        /// <summary>
        /// QQMKEY.
        /// </summary>
        public const string QQMKEY = "QQMKEY";

        /// <summary>
        /// QQUDTTM.
        /// </summary>
        public const string QQUDTTM = "QQUDTTM";

        /// <summary>
        /// QQJOBN.
        /// </summary>
        public const string QQJOBN = "QQJOBN";

        /// <summary>
        /// QQVID.
        /// </summary>
        public const string QQVID = "QQVID";

        /// <summary>
        /// QQPID.
        /// </summary>
        public const string QQPID = "QQPID";

        /// <summary>
        /// QQUPMT.
        /// </summary>
        public const string QQUPMT = "QQUPMT";

        /// <summary>
        /// QQUPMJ.
        /// </summary>
        public const string QQUPMJ = "QQUPMJ";

        /// <summary>
        /// QQEXNM0.
        /// </summary>
        public const string QQEXNM0 = "QQEXNM0";

        /// <summary>
        /// QQEXNM1.
        /// </summary>
        public const string QQEXNM1 = "QQEXNM1";

        /// <summary>
        /// QQEXNM2.
        /// </summary>
        public const string QQEXNM2 = "QQEXNM2";

        /// <summary>
        /// QQEXNMP0.
        /// </summary>
        public const string QQEXNMP0 = "QQEXNMP0";

        /// <summary>
        /// QQEXNMP1.
        /// </summary>
        public const string QQEXNMP1 = "QQEXNMP1";

        /// <summary>
        /// QQEXNMP2.
        /// </summary>
        public const string QQEXNMP2 = "QQEXNMP2";
    }

    /// <inheritdoc />
    public override string TableName => "F90CB042";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("QQQQ8", "QQQQ8", JdeDataType.Numeric, null, true, true),
        new JdeField("QQACTIND", "QQACTIND", JdeDataType.String, 2),
        new JdeField("QQQL8", "QQQL8", JdeDataType.Numeric),
        new JdeField("QQQLQT", "QQQLQT", JdeDataType.String, 10),
        new JdeField("QQQQSE", "QQQQSE", JdeDataType.Numeric),
        new JdeField("QQQLWV", "QQQLWV", JdeDataType.Numeric),
        new JdeField("QQQLQV", "QQQLQV", JdeDataType.String, 3998),
        new JdeField("QQEXVAR0", "QQEXVAR0", JdeDataType.String, 510),
        new JdeField("QQEXVAR1", "QQEXVAR1", JdeDataType.String, 510),
        new JdeField("QQEXVAR2", "QQEXVAR2", JdeDataType.String, 510),
        new JdeField("QQEXVAR3", "QQEXVAR3", JdeDataType.String, 510),
        new JdeField("QQEXVAR4", "QQEXVAR4", JdeDataType.String, 100),
        new JdeField("QQEXVAR5", "QQEXVAR5", JdeDataType.String, 100),
        new JdeField("QQEXVAR6", "QQEXVAR6", JdeDataType.String, 100),
        new JdeField("QQEXVAR7", "QQEXVAR7", JdeDataType.String, 100),
        new JdeField("QQEXDT0", "QQEXDT0", JdeDataType.Date),
        new JdeField("QQEXDT1", "QQEXDT1", JdeDataType.Date),
        new JdeField("QQEXDT2", "QQEXDT2", JdeDataType.Date),
        new JdeField("QQENTDBY", "QQENTDBY", JdeDataType.Numeric),
        new JdeField("QQMODB", "QQMODB", JdeDataType.Numeric),
        new JdeField("QQSTSUDT", "QQSTSUDT", JdeDataType.Date),
        new JdeField("QQEDATE", "QQEDATE", JdeDataType.Date),
        new JdeField("QQMDATE", "QQMDATE", JdeDataType.Date),
        new JdeField("QQUSER", "QQUSER", JdeDataType.String, 20),
        new JdeField("QQMKEY", "QQMKEY", JdeDataType.String, 30),
        new JdeField("QQUDTTM", "QQUDTTM", JdeDataType.Date),
        new JdeField("QQJOBN", "QQJOBN", JdeDataType.String, 20),
        new JdeField("QQVID", "QQVID", JdeDataType.String, 20),
        new JdeField("QQPID", "QQPID", JdeDataType.String, 20),
        new JdeField("QQUPMT", "QQUPMT", JdeDataType.Numeric),
        new JdeField("QQUPMJ", "QQUPMJ", JdeDataType.Numeric),
        new JdeField("QQEXNM0", "QQEXNM0", JdeDataType.Numeric),
        new JdeField("QQEXNM1", "QQEXNM1", JdeDataType.Numeric),
        new JdeField("QQEXNM2", "QQEXNM2", JdeDataType.Numeric),
        new JdeField("QQEXNMP0", "QQEXNMP0", JdeDataType.Numeric),
        new JdeField("QQEXNMP1", "QQEXNMP1", JdeDataType.Numeric),
        new JdeField("QQEXNMP2", "QQEXNMP2", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F90CB042_0", "Primary Key on QQQQ8", new[] { "QQQQ8" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F90CB042_4", "Index on QQQL8", new[] { "QQQL8" })
    };
}
