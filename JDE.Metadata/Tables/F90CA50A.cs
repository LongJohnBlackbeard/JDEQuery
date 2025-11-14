using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F90CA50A - .
/// </summary>
public class F90CA50A : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// MEMEMBERID.
        /// </summary>
        public const string MEMEMBERID = "MEMEMBERID";

        /// <summary>
        /// MEEMAILID.
        /// </summary>
        public const string MEEMAILID = "MEEMAILID";

        /// <summary>
        /// MEEGRPID.
        /// </summary>
        public const string MEEGRPID = "MEEGRPID";

        /// <summary>
        /// MEGRPLNKNAME.
        /// </summary>
        public const string MEGRPLNKNAME = "MEGRPLNKNAME";

        /// <summary>
        /// MEUSER.
        /// </summary>
        public const string MEUSER = "MEUSER";

        /// <summary>
        /// MEEDATE.
        /// </summary>
        public const string MEEDATE = "MEEDATE";

        /// <summary>
        /// MEMKEY.
        /// </summary>
        public const string MEMKEY = "MEMKEY";

        /// <summary>
        /// MEUDTTM.
        /// </summary>
        public const string MEUDTTM = "MEUDTTM";

        /// <summary>
        /// MEENTDBY.
        /// </summary>
        public const string MEENTDBY = "MEENTDBY";

        /// <summary>
        /// MEEXDT0.
        /// </summary>
        public const string MEEXDT0 = "MEEXDT0";

        /// <summary>
        /// MEEXDT1.
        /// </summary>
        public const string MEEXDT1 = "MEEXDT1";

        /// <summary>
        /// MEEXDT2.
        /// </summary>
        public const string MEEXDT2 = "MEEXDT2";

        /// <summary>
        /// MEEXNM0.
        /// </summary>
        public const string MEEXNM0 = "MEEXNM0";

        /// <summary>
        /// MEEXNM1.
        /// </summary>
        public const string MEEXNM1 = "MEEXNM1";

        /// <summary>
        /// MEEXNM2.
        /// </summary>
        public const string MEEXNM2 = "MEEXNM2";

        /// <summary>
        /// MEEXNMP0.
        /// </summary>
        public const string MEEXNMP0 = "MEEXNMP0";

        /// <summary>
        /// MEEXNMP1.
        /// </summary>
        public const string MEEXNMP1 = "MEEXNMP1";

        /// <summary>
        /// MEEXNMP2.
        /// </summary>
        public const string MEEXNMP2 = "MEEXNMP2";

        /// <summary>
        /// MEEXVAR0.
        /// </summary>
        public const string MEEXVAR0 = "MEEXVAR0";

        /// <summary>
        /// MEEXVAR1.
        /// </summary>
        public const string MEEXVAR1 = "MEEXVAR1";

        /// <summary>
        /// MEEXVAR2.
        /// </summary>
        public const string MEEXVAR2 = "MEEXVAR2";

        /// <summary>
        /// MEEXVAR3.
        /// </summary>
        public const string MEEXVAR3 = "MEEXVAR3";

        /// <summary>
        /// MEEXVAR4.
        /// </summary>
        public const string MEEXVAR4 = "MEEXVAR4";

        /// <summary>
        /// MEEXVAR5.
        /// </summary>
        public const string MEEXVAR5 = "MEEXVAR5";

        /// <summary>
        /// MEEXVAR6.
        /// </summary>
        public const string MEEXVAR6 = "MEEXVAR6";

        /// <summary>
        /// MEEXVAR7.
        /// </summary>
        public const string MEEXVAR7 = "MEEXVAR7";

        /// <summary>
        /// MEPID.
        /// </summary>
        public const string MEPID = "MEPID";

        /// <summary>
        /// MEACTIND.
        /// </summary>
        public const string MEACTIND = "MEACTIND";

        /// <summary>
        /// MESTSUDT.
        /// </summary>
        public const string MESTSUDT = "MESTSUDT";
    }

    /// <inheritdoc />
    public override string TableName => "F90CA50A";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("MEMEMBERID", "MEMEMBERID", JdeDataType.Numeric, null, true, true),
        new JdeField("MEEMAILID", "MEEMAILID", JdeDataType.Numeric),
        new JdeField("MEEGRPID", "MEEGRPID", JdeDataType.Numeric),
        new JdeField("MEGRPLNKNAME", "MEGRPLNKNAME", JdeDataType.String, 150),
        new JdeField("MEUSER", "MEUSER", JdeDataType.String, 20),
        new JdeField("MEEDATE", "MEEDATE", JdeDataType.Date),
        new JdeField("MEMKEY", "MEMKEY", JdeDataType.String, 30),
        new JdeField("MEUDTTM", "MEUDTTM", JdeDataType.Date),
        new JdeField("MEENTDBY", "MEENTDBY", JdeDataType.Numeric),
        new JdeField("MEEXDT0", "MEEXDT0", JdeDataType.Date),
        new JdeField("MEEXDT1", "MEEXDT1", JdeDataType.Date),
        new JdeField("MEEXDT2", "MEEXDT2", JdeDataType.Date),
        new JdeField("MEEXNM0", "MEEXNM0", JdeDataType.Numeric),
        new JdeField("MEEXNM1", "MEEXNM1", JdeDataType.Numeric),
        new JdeField("MEEXNM2", "MEEXNM2", JdeDataType.Numeric),
        new JdeField("MEEXNMP0", "MEEXNMP0", JdeDataType.Numeric),
        new JdeField("MEEXNMP1", "MEEXNMP1", JdeDataType.Numeric),
        new JdeField("MEEXNMP2", "MEEXNMP2", JdeDataType.Numeric),
        new JdeField("MEEXVAR0", "MEEXVAR0", JdeDataType.String, 510),
        new JdeField("MEEXVAR1", "MEEXVAR1", JdeDataType.String, 510),
        new JdeField("MEEXVAR2", "MEEXVAR2", JdeDataType.String, 510),
        new JdeField("MEEXVAR3", "MEEXVAR3", JdeDataType.String, 510),
        new JdeField("MEEXVAR4", "MEEXVAR4", JdeDataType.String, 100),
        new JdeField("MEEXVAR5", "MEEXVAR5", JdeDataType.String, 100),
        new JdeField("MEEXVAR6", "MEEXVAR6", JdeDataType.String, 100),
        new JdeField("MEEXVAR7", "MEEXVAR7", JdeDataType.String, 100),
        new JdeField("MEPID", "MEPID", JdeDataType.String, 20),
        new JdeField("MEACTIND", "MEACTIND", JdeDataType.String, 2),
        new JdeField("MESTSUDT", "MESTSUDT", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F90CA50A_0", "Primary Key on MEMEMBERID", new[] { "MEMEMBERID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F90CA50A_2", "Index on MEEGRPID", new[] { "MEEGRPID" })
    };
}
