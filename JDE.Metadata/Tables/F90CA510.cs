using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F90CA510 - .
/// </summary>
public class F90CA510 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// EGEGRPID.
        /// </summary>
        public const string EGEGRPID = "EGEGRPID";

        /// <summary>
        /// EGEGRPNAME.
        /// </summary>
        public const string EGEGRPNAME = "EGEGRPNAME";

        /// <summary>
        /// EGECOMM.
        /// </summary>
        public const string EGECOMM = "EGECOMM";

        /// <summary>
        /// EGEGRPTYPE.
        /// </summary>
        public const string EGEGRPTYPE = "EGEGRPTYPE";

        /// <summary>
        /// EGUDTTM.
        /// </summary>
        public const string EGUDTTM = "EGUDTTM";

        /// <summary>
        /// EGUSER.
        /// </summary>
        public const string EGUSER = "EGUSER";

        /// <summary>
        /// EGENTDBY.
        /// </summary>
        public const string EGENTDBY = "EGENTDBY";

        /// <summary>
        /// EGEDATE.
        /// </summary>
        public const string EGEDATE = "EGEDATE";

        /// <summary>
        /// EGMKEY.
        /// </summary>
        public const string EGMKEY = "EGMKEY";

        /// <summary>
        /// EGEXDT0.
        /// </summary>
        public const string EGEXDT0 = "EGEXDT0";

        /// <summary>
        /// EGEXDT1.
        /// </summary>
        public const string EGEXDT1 = "EGEXDT1";

        /// <summary>
        /// EGEXDT2.
        /// </summary>
        public const string EGEXDT2 = "EGEXDT2";

        /// <summary>
        /// EGEXNM0.
        /// </summary>
        public const string EGEXNM0 = "EGEXNM0";

        /// <summary>
        /// EGEXNM1.
        /// </summary>
        public const string EGEXNM1 = "EGEXNM1";

        /// <summary>
        /// EGEXNM2.
        /// </summary>
        public const string EGEXNM2 = "EGEXNM2";

        /// <summary>
        /// EGEXNMP0.
        /// </summary>
        public const string EGEXNMP0 = "EGEXNMP0";

        /// <summary>
        /// EGEXNMP1.
        /// </summary>
        public const string EGEXNMP1 = "EGEXNMP1";

        /// <summary>
        /// EGEXNMP2.
        /// </summary>
        public const string EGEXNMP2 = "EGEXNMP2";

        /// <summary>
        /// EGEXVAR0.
        /// </summary>
        public const string EGEXVAR0 = "EGEXVAR0";

        /// <summary>
        /// EGEXVAR1.
        /// </summary>
        public const string EGEXVAR1 = "EGEXVAR1";

        /// <summary>
        /// EGEXVAR2.
        /// </summary>
        public const string EGEXVAR2 = "EGEXVAR2";

        /// <summary>
        /// EGEXVAR3.
        /// </summary>
        public const string EGEXVAR3 = "EGEXVAR3";

        /// <summary>
        /// EGEXVAR4.
        /// </summary>
        public const string EGEXVAR4 = "EGEXVAR4";

        /// <summary>
        /// EGEXVAR5.
        /// </summary>
        public const string EGEXVAR5 = "EGEXVAR5";

        /// <summary>
        /// EGEXVAR6.
        /// </summary>
        public const string EGEXVAR6 = "EGEXVAR6";

        /// <summary>
        /// EGEXVAR7.
        /// </summary>
        public const string EGEXVAR7 = "EGEXVAR7";

        /// <summary>
        /// EGPID.
        /// </summary>
        public const string EGPID = "EGPID";

        /// <summary>
        /// EGACTIND.
        /// </summary>
        public const string EGACTIND = "EGACTIND";

        /// <summary>
        /// EGSTSUDT.
        /// </summary>
        public const string EGSTSUDT = "EGSTSUDT";
    }

    /// <inheritdoc />
    public override string TableName => "F90CA510";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("EGEGRPID", "EGEGRPID", JdeDataType.Numeric, null, true, true),
        new JdeField("EGEGRPNAME", "EGEGRPNAME", JdeDataType.String, 150),
        new JdeField("EGECOMM", "EGECOMM", JdeDataType.String, 3998),
        new JdeField("EGEGRPTYPE", "EGEGRPTYPE", JdeDataType.String, 10),
        new JdeField("EGUDTTM", "EGUDTTM", JdeDataType.Date),
        new JdeField("EGUSER", "EGUSER", JdeDataType.String, 20),
        new JdeField("EGENTDBY", "EGENTDBY", JdeDataType.Numeric),
        new JdeField("EGEDATE", "EGEDATE", JdeDataType.Date),
        new JdeField("EGMKEY", "EGMKEY", JdeDataType.String, 30),
        new JdeField("EGEXDT0", "EGEXDT0", JdeDataType.Date),
        new JdeField("EGEXDT1", "EGEXDT1", JdeDataType.Date),
        new JdeField("EGEXDT2", "EGEXDT2", JdeDataType.Date),
        new JdeField("EGEXNM0", "EGEXNM0", JdeDataType.Numeric),
        new JdeField("EGEXNM1", "EGEXNM1", JdeDataType.Numeric),
        new JdeField("EGEXNM2", "EGEXNM2", JdeDataType.Numeric),
        new JdeField("EGEXNMP0", "EGEXNMP0", JdeDataType.Numeric),
        new JdeField("EGEXNMP1", "EGEXNMP1", JdeDataType.Numeric),
        new JdeField("EGEXNMP2", "EGEXNMP2", JdeDataType.Numeric),
        new JdeField("EGEXVAR0", "EGEXVAR0", JdeDataType.String, 510),
        new JdeField("EGEXVAR1", "EGEXVAR1", JdeDataType.String, 510),
        new JdeField("EGEXVAR2", "EGEXVAR2", JdeDataType.String, 510),
        new JdeField("EGEXVAR3", "EGEXVAR3", JdeDataType.String, 510),
        new JdeField("EGEXVAR4", "EGEXVAR4", JdeDataType.String, 100),
        new JdeField("EGEXVAR5", "EGEXVAR5", JdeDataType.String, 100),
        new JdeField("EGEXVAR6", "EGEXVAR6", JdeDataType.String, 100),
        new JdeField("EGEXVAR7", "EGEXVAR7", JdeDataType.String, 100),
        new JdeField("EGPID", "EGPID", JdeDataType.String, 20),
        new JdeField("EGACTIND", "EGACTIND", JdeDataType.String, 2),
        new JdeField("EGSTSUDT", "EGSTSUDT", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F90CA510_0", "Primary Key on EGEGRPID", new[] { "EGEGRPID" }, isUnique: true, isPrimaryKey: true)
    };
}
