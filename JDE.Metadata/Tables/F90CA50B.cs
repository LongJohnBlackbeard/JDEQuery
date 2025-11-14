using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F90CA50B - .
/// </summary>
public class F90CA50B : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// MEAN8.
        /// </summary>
        public const string MEAN8 = "MEAN8";

        /// <summary>
        /// MEIDLN.
        /// </summary>
        public const string MEIDLN = "MEIDLN";

        /// <summary>
        /// MERCK7.
        /// </summary>
        public const string MERCK7 = "MERCK7";

        /// <summary>
        /// MEMEMBERID.
        /// </summary>
        public const string MEMEMBERID = "MEMEMBERID";

        /// <summary>
        /// MEAT1.
        /// </summary>
        public const string MEAT1 = "MEAT1";

        /// <summary>
        /// MEEDATE.
        /// </summary>
        public const string MEEDATE = "MEEDATE";

        /// <summary>
        /// MEUDTTM.
        /// </summary>
        public const string MEUDTTM = "MEUDTTM";

        /// <summary>
        /// MEENTDBY.
        /// </summary>
        public const string MEENTDBY = "MEENTDBY";

        /// <summary>
        /// MEMKEY.
        /// </summary>
        public const string MEMKEY = "MEMKEY";

        /// <summary>
        /// MEUSER.
        /// </summary>
        public const string MEUSER = "MEUSER";

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
        /// MEACTIND.
        /// </summary>
        public const string MEACTIND = "MEACTIND";

        /// <summary>
        /// MEPID.
        /// </summary>
        public const string MEPID = "MEPID";

        /// <summary>
        /// MESNTFLG.
        /// </summary>
        public const string MESNTFLG = "MESNTFLG";

        /// <summary>
        /// MEEMSTAT.
        /// </summary>
        public const string MEEMSTAT = "MEEMSTAT";
    }

    /// <inheritdoc />
    public override string TableName => "F90CA50B";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("MEAN8", "MEAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("MEIDLN", "MEIDLN", JdeDataType.Numeric, null, true, true),
        new JdeField("MERCK7", "MERCK7", JdeDataType.Numeric, null, true, true),
        new JdeField("MEMEMBERID", "MEMEMBERID", JdeDataType.Numeric, null, true, true),
        new JdeField("MEAT1", "MEAT1", JdeDataType.String, 6),
        new JdeField("MEEDATE", "MEEDATE", JdeDataType.Date),
        new JdeField("MEUDTTM", "MEUDTTM", JdeDataType.Date),
        new JdeField("MEENTDBY", "MEENTDBY", JdeDataType.Numeric),
        new JdeField("MEMKEY", "MEMKEY", JdeDataType.String, 30),
        new JdeField("MEUSER", "MEUSER", JdeDataType.String, 20),
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
        new JdeField("MEACTIND", "MEACTIND", JdeDataType.String, 2),
        new JdeField("MEPID", "MEPID", JdeDataType.String, 20),
        new JdeField("MESNTFLG", "MESNTFLG", JdeDataType.String, 2),
        new JdeField("MEEMSTAT", "MEEMSTAT", JdeDataType.String, 200)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F90CA50B_0", "Primary Key on MEMEMBERID, MERCK7, MEIDLN, MEAN8", new[] { "MEMEMBERID", "MERCK7", "MEIDLN", "MEAN8" }, isUnique: true, isPrimaryKey: true)
    };
}
