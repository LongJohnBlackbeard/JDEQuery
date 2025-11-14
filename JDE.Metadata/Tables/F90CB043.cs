using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F90CB043 - .
/// </summary>
public class F90CB043 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// QOQO8.
        /// </summary>
        public const string QOQO8 = "QOQO8";

        /// <summary>
        /// QOQA8.
        /// </summary>
        public const string QOQA8 = "QOQA8";

        /// <summary>
        /// QOQQ8.
        /// </summary>
        public const string QOQQ8 = "QOQQ8";

        /// <summary>
        /// QOQLCV.
        /// </summary>
        public const string QOQLCV = "QOQLCV";

        /// <summary>
        /// QOACTIND.
        /// </summary>
        public const string QOACTIND = "QOACTIND";

        /// <summary>
        /// QOENTDBY.
        /// </summary>
        public const string QOENTDBY = "QOENTDBY";

        /// <summary>
        /// QOUSER.
        /// </summary>
        public const string QOUSER = "QOUSER";

        /// <summary>
        /// QOMKEY.
        /// </summary>
        public const string QOMKEY = "QOMKEY";

        /// <summary>
        /// QOPID.
        /// </summary>
        public const string QOPID = "QOPID";

        /// <summary>
        /// QOVID.
        /// </summary>
        public const string QOVID = "QOVID";

        /// <summary>
        /// QOUDTTM.
        /// </summary>
        public const string QOUDTTM = "QOUDTTM";

        /// <summary>
        /// QOLEADID.
        /// </summary>
        public const string QOLEADID = "QOLEADID";

        /// <summary>
        /// QOOPPID.
        /// </summary>
        public const string QOOPPID = "QOOPPID";

        /// <summary>
        /// QOEDATE.
        /// </summary>
        public const string QOEDATE = "QOEDATE";

        /// <summary>
        /// QOUPMT.
        /// </summary>
        public const string QOUPMT = "QOUPMT";

        /// <summary>
        /// QOEXNM0.
        /// </summary>
        public const string QOEXNM0 = "QOEXNM0";

        /// <summary>
        /// QOEXNM1.
        /// </summary>
        public const string QOEXNM1 = "QOEXNM1";

        /// <summary>
        /// QOEXNM2.
        /// </summary>
        public const string QOEXNM2 = "QOEXNM2";

        /// <summary>
        /// QOEXNMP0.
        /// </summary>
        public const string QOEXNMP0 = "QOEXNMP0";

        /// <summary>
        /// QOEXNMP1.
        /// </summary>
        public const string QOEXNMP1 = "QOEXNMP1";

        /// <summary>
        /// QOEXNMP2.
        /// </summary>
        public const string QOEXNMP2 = "QOEXNMP2";

        /// <summary>
        /// QOEXDT0.
        /// </summary>
        public const string QOEXDT0 = "QOEXDT0";

        /// <summary>
        /// QOEXDT1.
        /// </summary>
        public const string QOEXDT1 = "QOEXDT1";

        /// <summary>
        /// QOEXDT2.
        /// </summary>
        public const string QOEXDT2 = "QOEXDT2";

        /// <summary>
        /// QOEXVAR0.
        /// </summary>
        public const string QOEXVAR0 = "QOEXVAR0";

        /// <summary>
        /// QOEXVAR1.
        /// </summary>
        public const string QOEXVAR1 = "QOEXVAR1";

        /// <summary>
        /// QOEXVAR2.
        /// </summary>
        public const string QOEXVAR2 = "QOEXVAR2";

        /// <summary>
        /// QOEXVAR3.
        /// </summary>
        public const string QOEXVAR3 = "QOEXVAR3";

        /// <summary>
        /// QOEXVAR4.
        /// </summary>
        public const string QOEXVAR4 = "QOEXVAR4";

        /// <summary>
        /// QOEXVAR5.
        /// </summary>
        public const string QOEXVAR5 = "QOEXVAR5";

        /// <summary>
        /// QOEXVAR6.
        /// </summary>
        public const string QOEXVAR6 = "QOEXVAR6";

        /// <summary>
        /// QOEXVAR7.
        /// </summary>
        public const string QOEXVAR7 = "QOEXVAR7";

        /// <summary>
        /// QOSTSUDT.
        /// </summary>
        public const string QOSTSUDT = "QOSTSUDT";
    }

    /// <inheritdoc />
    public override string TableName => "F90CB043";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("QOQO8", "QOQO8", JdeDataType.Numeric, null, true, true),
        new JdeField("QOQA8", "QOQA8", JdeDataType.Numeric),
        new JdeField("QOQQ8", "QOQQ8", JdeDataType.Numeric),
        new JdeField("QOQLCV", "QOQLCV", JdeDataType.String, 3998),
        new JdeField("QOACTIND", "QOACTIND", JdeDataType.String, 2),
        new JdeField("QOENTDBY", "QOENTDBY", JdeDataType.Numeric),
        new JdeField("QOUSER", "QOUSER", JdeDataType.String, 20),
        new JdeField("QOMKEY", "QOMKEY", JdeDataType.String, 30),
        new JdeField("QOPID", "QOPID", JdeDataType.String, 20),
        new JdeField("QOVID", "QOVID", JdeDataType.String, 20),
        new JdeField("QOUDTTM", "QOUDTTM", JdeDataType.Date),
        new JdeField("QOLEADID", "QOLEADID", JdeDataType.Numeric),
        new JdeField("QOOPPID", "QOOPPID", JdeDataType.Numeric),
        new JdeField("QOEDATE", "QOEDATE", JdeDataType.Date),
        new JdeField("QOUPMT", "QOUPMT", JdeDataType.Numeric),
        new JdeField("QOEXNM0", "QOEXNM0", JdeDataType.Numeric),
        new JdeField("QOEXNM1", "QOEXNM1", JdeDataType.Numeric),
        new JdeField("QOEXNM2", "QOEXNM2", JdeDataType.Numeric),
        new JdeField("QOEXNMP0", "QOEXNMP0", JdeDataType.Numeric),
        new JdeField("QOEXNMP1", "QOEXNMP1", JdeDataType.Numeric),
        new JdeField("QOEXNMP2", "QOEXNMP2", JdeDataType.Numeric),
        new JdeField("QOEXDT0", "QOEXDT0", JdeDataType.Date),
        new JdeField("QOEXDT1", "QOEXDT1", JdeDataType.Date),
        new JdeField("QOEXDT2", "QOEXDT2", JdeDataType.Date),
        new JdeField("QOEXVAR0", "QOEXVAR0", JdeDataType.String, 510),
        new JdeField("QOEXVAR1", "QOEXVAR1", JdeDataType.String, 510),
        new JdeField("QOEXVAR2", "QOEXVAR2", JdeDataType.String, 510),
        new JdeField("QOEXVAR3", "QOEXVAR3", JdeDataType.String, 510),
        new JdeField("QOEXVAR4", "QOEXVAR4", JdeDataType.String, 100),
        new JdeField("QOEXVAR5", "QOEXVAR5", JdeDataType.String, 100),
        new JdeField("QOEXVAR6", "QOEXVAR6", JdeDataType.String, 100),
        new JdeField("QOEXVAR7", "QOEXVAR7", JdeDataType.String, 100),
        new JdeField("QOSTSUDT", "QOSTSUDT", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F90CB043_0", "Primary Key on QOQO8", new[] { "QOQO8" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F90CB043_2", "Index on QOLEADID", new[] { "QOLEADID" }),
        new JdeIndex("F90CB043_3", "Index on QOOPPID", new[] { "QOOPPID" })
    };
}
