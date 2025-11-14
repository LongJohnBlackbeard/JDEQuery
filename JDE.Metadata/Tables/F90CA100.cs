using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F90CA100 - .
/// </summary>
public class F90CA100 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ITITM.
        /// </summary>
        public const string ITITM = "ITITM";

        /// <summary>
        /// ITPBFLG.
        /// </summary>
        public const string ITPBFLG = "ITPBFLG";

        /// <summary>
        /// ITSRVGRP.
        /// </summary>
        public const string ITSRVGRP = "ITSRVGRP";

        /// <summary>
        /// ITENTDBY.
        /// </summary>
        public const string ITENTDBY = "ITENTDBY";

        /// <summary>
        /// ITEDATE.
        /// </summary>
        public const string ITEDATE = "ITEDATE";

        /// <summary>
        /// ITEXVAR0.
        /// </summary>
        public const string ITEXVAR0 = "ITEXVAR0";

        /// <summary>
        /// ITEXVAR1.
        /// </summary>
        public const string ITEXVAR1 = "ITEXVAR1";

        /// <summary>
        /// ITEXVAR4.
        /// </summary>
        public const string ITEXVAR4 = "ITEXVAR4";

        /// <summary>
        /// ITEXVAR5.
        /// </summary>
        public const string ITEXVAR5 = "ITEXVAR5";

        /// <summary>
        /// ITEXVAR6.
        /// </summary>
        public const string ITEXVAR6 = "ITEXVAR6";

        /// <summary>
        /// ITEXVAR7.
        /// </summary>
        public const string ITEXVAR7 = "ITEXVAR7";

        /// <summary>
        /// ITEXVAR12.
        /// </summary>
        public const string ITEXVAR12 = "ITEXVAR12";

        /// <summary>
        /// ITEXVAR13.
        /// </summary>
        public const string ITEXVAR13 = "ITEXVAR13";

        /// <summary>
        /// ITEXNM0.
        /// </summary>
        public const string ITEXNM0 = "ITEXNM0";

        /// <summary>
        /// ITEXNM1.
        /// </summary>
        public const string ITEXNM1 = "ITEXNM1";

        /// <summary>
        /// ITEXNM2.
        /// </summary>
        public const string ITEXNM2 = "ITEXNM2";

        /// <summary>
        /// ITEXNMP0.
        /// </summary>
        public const string ITEXNMP0 = "ITEXNMP0";

        /// <summary>
        /// ITEXNMP1.
        /// </summary>
        public const string ITEXNMP1 = "ITEXNMP1";

        /// <summary>
        /// ITEXNMP2.
        /// </summary>
        public const string ITEXNMP2 = "ITEXNMP2";

        /// <summary>
        /// ITEXDT0.
        /// </summary>
        public const string ITEXDT0 = "ITEXDT0";

        /// <summary>
        /// ITEXDT1.
        /// </summary>
        public const string ITEXDT1 = "ITEXDT1";

        /// <summary>
        /// ITEXDT2.
        /// </summary>
        public const string ITEXDT2 = "ITEXDT2";

        /// <summary>
        /// ITSTSUDT.
        /// </summary>
        public const string ITSTSUDT = "ITSTSUDT";

        /// <summary>
        /// ITACTIND.
        /// </summary>
        public const string ITACTIND = "ITACTIND";

        /// <summary>
        /// ITUSER.
        /// </summary>
        public const string ITUSER = "ITUSER";

        /// <summary>
        /// ITPID.
        /// </summary>
        public const string ITPID = "ITPID";

        /// <summary>
        /// ITVID.
        /// </summary>
        public const string ITVID = "ITVID";

        /// <summary>
        /// ITMKEY.
        /// </summary>
        public const string ITMKEY = "ITMKEY";

        /// <summary>
        /// ITUDTTM.
        /// </summary>
        public const string ITUDTTM = "ITUDTTM";

        /// <summary>
        /// ITJOBN.
        /// </summary>
        public const string ITJOBN = "ITJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F90CA100";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ITITM", "ITITM", JdeDataType.Numeric, null, true, true),
        new JdeField("ITPBFLG", "ITPBFLG", JdeDataType.String, 2),
        new JdeField("ITSRVGRP", "ITSRVGRP", JdeDataType.Numeric),
        new JdeField("ITENTDBY", "ITENTDBY", JdeDataType.Numeric),
        new JdeField("ITEDATE", "ITEDATE", JdeDataType.Date),
        new JdeField("ITEXVAR0", "ITEXVAR0", JdeDataType.String, 510),
        new JdeField("ITEXVAR1", "ITEXVAR1", JdeDataType.String, 510),
        new JdeField("ITEXVAR4", "ITEXVAR4", JdeDataType.String, 100),
        new JdeField("ITEXVAR5", "ITEXVAR5", JdeDataType.String, 100),
        new JdeField("ITEXVAR6", "ITEXVAR6", JdeDataType.String, 100),
        new JdeField("ITEXVAR7", "ITEXVAR7", JdeDataType.String, 100),
        new JdeField("ITEXVAR12", "ITEXVAR12", JdeDataType.String, 50),
        new JdeField("ITEXVAR13", "ITEXVAR13", JdeDataType.String, 50),
        new JdeField("ITEXNM0", "ITEXNM0", JdeDataType.Numeric),
        new JdeField("ITEXNM1", "ITEXNM1", JdeDataType.Numeric),
        new JdeField("ITEXNM2", "ITEXNM2", JdeDataType.Numeric),
        new JdeField("ITEXNMP0", "ITEXNMP0", JdeDataType.Numeric),
        new JdeField("ITEXNMP1", "ITEXNMP1", JdeDataType.Numeric),
        new JdeField("ITEXNMP2", "ITEXNMP2", JdeDataType.Numeric),
        new JdeField("ITEXDT0", "ITEXDT0", JdeDataType.Date),
        new JdeField("ITEXDT1", "ITEXDT1", JdeDataType.Date),
        new JdeField("ITEXDT2", "ITEXDT2", JdeDataType.Date),
        new JdeField("ITSTSUDT", "ITSTSUDT", JdeDataType.Date),
        new JdeField("ITACTIND", "ITACTIND", JdeDataType.String, 2),
        new JdeField("ITUSER", "ITUSER", JdeDataType.String, 20),
        new JdeField("ITPID", "ITPID", JdeDataType.String, 20),
        new JdeField("ITVID", "ITVID", JdeDataType.String, 20),
        new JdeField("ITMKEY", "ITMKEY", JdeDataType.String, 30),
        new JdeField("ITUDTTM", "ITUDTTM", JdeDataType.Date),
        new JdeField("ITJOBN", "ITJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F90CA100_0", "Primary Key on ITITM", new[] { "ITITM" }, isUnique: true, isPrimaryKey: true)
    };
}
