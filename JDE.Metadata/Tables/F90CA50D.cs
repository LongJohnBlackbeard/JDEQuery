using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F90CA50D - .
/// </summary>
public class F90CA50D : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// EMEMAILID.
        /// </summary>
        public const string EMEMAILID = "EMEMAILID";

        /// <summary>
        /// EMAN8.
        /// </summary>
        public const string EMAN8 = "EMAN8";

        /// <summary>
        /// EMIDLN.
        /// </summary>
        public const string EMIDLN = "EMIDLN";

        /// <summary>
        /// EMENTDBY.
        /// </summary>
        public const string EMENTDBY = "EMENTDBY";

        /// <summary>
        /// EMEDATE.
        /// </summary>
        public const string EMEDATE = "EMEDATE";

        /// <summary>
        /// EMMKEY.
        /// </summary>
        public const string EMMKEY = "EMMKEY";

        /// <summary>
        /// EMUDTTM.
        /// </summary>
        public const string EMUDTTM = "EMUDTTM";

        /// <summary>
        /// EMUSER.
        /// </summary>
        public const string EMUSER = "EMUSER";

        /// <summary>
        /// EMACTIND.
        /// </summary>
        public const string EMACTIND = "EMACTIND";

        /// <summary>
        /// EMSNTFLG.
        /// </summary>
        public const string EMSNTFLG = "EMSNTFLG";

        /// <summary>
        /// EMEGRPTYPE.
        /// </summary>
        public const string EMEGRPTYPE = "EMEGRPTYPE";

        /// <summary>
        /// EMSTSUDT.
        /// </summary>
        public const string EMSTSUDT = "EMSTSUDT";

        /// <summary>
        /// EMEXVAR0.
        /// </summary>
        public const string EMEXVAR0 = "EMEXVAR0";

        /// <summary>
        /// EMEXVAR1.
        /// </summary>
        public const string EMEXVAR1 = "EMEXVAR1";

        /// <summary>
        /// EMEXVAR2.
        /// </summary>
        public const string EMEXVAR2 = "EMEXVAR2";

        /// <summary>
        /// EMEXVAR3.
        /// </summary>
        public const string EMEXVAR3 = "EMEXVAR3";

        /// <summary>
        /// EMEXVAR4.
        /// </summary>
        public const string EMEXVAR4 = "EMEXVAR4";

        /// <summary>
        /// EMEXVAR5.
        /// </summary>
        public const string EMEXVAR5 = "EMEXVAR5";

        /// <summary>
        /// EMEXVAR6.
        /// </summary>
        public const string EMEXVAR6 = "EMEXVAR6";

        /// <summary>
        /// EMEXVAR7.
        /// </summary>
        public const string EMEXVAR7 = "EMEXVAR7";

        /// <summary>
        /// EMEXNM1.
        /// </summary>
        public const string EMEXNM1 = "EMEXNM1";

        /// <summary>
        /// EMEXNM2.
        /// </summary>
        public const string EMEXNM2 = "EMEXNM2";

        /// <summary>
        /// EMEXNM0.
        /// </summary>
        public const string EMEXNM0 = "EMEXNM0";

        /// <summary>
        /// EMEXNMP0.
        /// </summary>
        public const string EMEXNMP0 = "EMEXNMP0";

        /// <summary>
        /// EMEXNMP1.
        /// </summary>
        public const string EMEXNMP1 = "EMEXNMP1";

        /// <summary>
        /// EMEXNMP2.
        /// </summary>
        public const string EMEXNMP2 = "EMEXNMP2";

        /// <summary>
        /// EMEXDT0.
        /// </summary>
        public const string EMEXDT0 = "EMEXDT0";

        /// <summary>
        /// EMEXDT1.
        /// </summary>
        public const string EMEXDT1 = "EMEXDT1";

        /// <summary>
        /// EMEXDT2.
        /// </summary>
        public const string EMEXDT2 = "EMEXDT2";
    }

    /// <inheritdoc />
    public override string TableName => "F90CA50D";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("EMEMAILID", "EMEMAILID", JdeDataType.Numeric, null, true, true),
        new JdeField("EMAN8", "EMAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("EMIDLN", "EMIDLN", JdeDataType.Numeric, null, true, true),
        new JdeField("EMENTDBY", "EMENTDBY", JdeDataType.Numeric),
        new JdeField("EMEDATE", "EMEDATE", JdeDataType.Date),
        new JdeField("EMMKEY", "EMMKEY", JdeDataType.String, 30),
        new JdeField("EMUDTTM", "EMUDTTM", JdeDataType.Date),
        new JdeField("EMUSER", "EMUSER", JdeDataType.String, 20),
        new JdeField("EMACTIND", "EMACTIND", JdeDataType.String, 2),
        new JdeField("EMSNTFLG", "EMSNTFLG", JdeDataType.String, 2),
        new JdeField("EMEGRPTYPE", "EMEGRPTYPE", JdeDataType.String, 10),
        new JdeField("EMSTSUDT", "EMSTSUDT", JdeDataType.Date),
        new JdeField("EMEXVAR0", "EMEXVAR0", JdeDataType.String, 510),
        new JdeField("EMEXVAR1", "EMEXVAR1", JdeDataType.String, 510),
        new JdeField("EMEXVAR2", "EMEXVAR2", JdeDataType.String, 510),
        new JdeField("EMEXVAR3", "EMEXVAR3", JdeDataType.String, 510),
        new JdeField("EMEXVAR4", "EMEXVAR4", JdeDataType.String, 100),
        new JdeField("EMEXVAR5", "EMEXVAR5", JdeDataType.String, 100),
        new JdeField("EMEXVAR6", "EMEXVAR6", JdeDataType.String, 100),
        new JdeField("EMEXVAR7", "EMEXVAR7", JdeDataType.String, 100),
        new JdeField("EMEXNM1", "EMEXNM1", JdeDataType.Numeric),
        new JdeField("EMEXNM2", "EMEXNM2", JdeDataType.Numeric),
        new JdeField("EMEXNM0", "EMEXNM0", JdeDataType.Numeric),
        new JdeField("EMEXNMP0", "EMEXNMP0", JdeDataType.Numeric),
        new JdeField("EMEXNMP1", "EMEXNMP1", JdeDataType.Numeric),
        new JdeField("EMEXNMP2", "EMEXNMP2", JdeDataType.Numeric),
        new JdeField("EMEXDT0", "EMEXDT0", JdeDataType.Date),
        new JdeField("EMEXDT1", "EMEXDT1", JdeDataType.Date),
        new JdeField("EMEXDT2", "EMEXDT2", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F90CA50D_0", "Primary Key on EMEMAILID, EMAN8, EMIDLN", new[] { "EMEMAILID", "EMAN8", "EMIDLN" }, isUnique: true, isPrimaryKey: true)
    };
}
