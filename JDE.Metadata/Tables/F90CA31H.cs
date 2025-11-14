using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F90CA31H - .
/// </summary>
public class F90CA31H : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// EXACTIVID.
        /// </summary>
        public const string EXACTIVID = "EXACTIVID";

        /// <summary>
        /// EXEXVAR0.
        /// </summary>
        public const string EXEXVAR0 = "EXEXVAR0";

        /// <summary>
        /// EXEXVAR1.
        /// </summary>
        public const string EXEXVAR1 = "EXEXVAR1";

        /// <summary>
        /// EXEXVAR2.
        /// </summary>
        public const string EXEXVAR2 = "EXEXVAR2";

        /// <summary>
        /// EXEXVAR3.
        /// </summary>
        public const string EXEXVAR3 = "EXEXVAR3";

        /// <summary>
        /// EXEXVAR4.
        /// </summary>
        public const string EXEXVAR4 = "EXEXVAR4";

        /// <summary>
        /// EXEXVAR5.
        /// </summary>
        public const string EXEXVAR5 = "EXEXVAR5";

        /// <summary>
        /// EXEXVAR6.
        /// </summary>
        public const string EXEXVAR6 = "EXEXVAR6";

        /// <summary>
        /// EXEXVAR7.
        /// </summary>
        public const string EXEXVAR7 = "EXEXVAR7";

        /// <summary>
        /// EXEXNM0.
        /// </summary>
        public const string EXEXNM0 = "EXEXNM0";

        /// <summary>
        /// EXEXNM1.
        /// </summary>
        public const string EXEXNM1 = "EXEXNM1";

        /// <summary>
        /// EXEXNM2.
        /// </summary>
        public const string EXEXNM2 = "EXEXNM2";

        /// <summary>
        /// EXEXNMP0.
        /// </summary>
        public const string EXEXNMP0 = "EXEXNMP0";

        /// <summary>
        /// EXEXNMP1.
        /// </summary>
        public const string EXEXNMP1 = "EXEXNMP1";

        /// <summary>
        /// EXEXNMP2.
        /// </summary>
        public const string EXEXNMP2 = "EXEXNMP2";

        /// <summary>
        /// EXEXDT0.
        /// </summary>
        public const string EXEXDT0 = "EXEXDT0";

        /// <summary>
        /// EXEXDT1.
        /// </summary>
        public const string EXEXDT1 = "EXEXDT1";

        /// <summary>
        /// EXEXDT2.
        /// </summary>
        public const string EXEXDT2 = "EXEXDT2";

        /// <summary>
        /// EXACTIND.
        /// </summary>
        public const string EXACTIND = "EXACTIND";

        /// <summary>
        /// EXUDTTM.
        /// </summary>
        public const string EXUDTTM = "EXUDTTM";

        /// <summary>
        /// EXSTSUDT.
        /// </summary>
        public const string EXSTSUDT = "EXSTSUDT";

        /// <summary>
        /// EXEDATE.
        /// </summary>
        public const string EXEDATE = "EXEDATE";

        /// <summary>
        /// EXENTDBY.
        /// </summary>
        public const string EXENTDBY = "EXENTDBY";

        /// <summary>
        /// EXUSER.
        /// </summary>
        public const string EXUSER = "EXUSER";
    }

    /// <inheritdoc />
    public override string TableName => "F90CA31H";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("EXACTIVID", "EXACTIVID", JdeDataType.String, 72, true, true),
        new JdeField("EXEXVAR0", "EXEXVAR0", JdeDataType.String, 510),
        new JdeField("EXEXVAR1", "EXEXVAR1", JdeDataType.String, 510),
        new JdeField("EXEXVAR2", "EXEXVAR2", JdeDataType.String, 510),
        new JdeField("EXEXVAR3", "EXEXVAR3", JdeDataType.String, 510),
        new JdeField("EXEXVAR4", "EXEXVAR4", JdeDataType.String, 100),
        new JdeField("EXEXVAR5", "EXEXVAR5", JdeDataType.String, 100),
        new JdeField("EXEXVAR6", "EXEXVAR6", JdeDataType.String, 100),
        new JdeField("EXEXVAR7", "EXEXVAR7", JdeDataType.String, 100),
        new JdeField("EXEXNM0", "EXEXNM0", JdeDataType.Numeric),
        new JdeField("EXEXNM1", "EXEXNM1", JdeDataType.Numeric),
        new JdeField("EXEXNM2", "EXEXNM2", JdeDataType.Numeric),
        new JdeField("EXEXNMP0", "EXEXNMP0", JdeDataType.Numeric),
        new JdeField("EXEXNMP1", "EXEXNMP1", JdeDataType.Numeric),
        new JdeField("EXEXNMP2", "EXEXNMP2", JdeDataType.Numeric),
        new JdeField("EXEXDT0", "EXEXDT0", JdeDataType.Date),
        new JdeField("EXEXDT1", "EXEXDT1", JdeDataType.Date),
        new JdeField("EXEXDT2", "EXEXDT2", JdeDataType.Date),
        new JdeField("EXACTIND", "EXACTIND", JdeDataType.String, 2),
        new JdeField("EXUDTTM", "EXUDTTM", JdeDataType.Date),
        new JdeField("EXSTSUDT", "EXSTSUDT", JdeDataType.Date),
        new JdeField("EXEDATE", "EXEDATE", JdeDataType.Date),
        new JdeField("EXENTDBY", "EXENTDBY", JdeDataType.Numeric),
        new JdeField("EXUSER", "EXUSER", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F90CA31H_0", "Primary Key on EXACTIVID", new[] { "EXACTIVID" }, isUnique: true, isPrimaryKey: true)
    };
}
