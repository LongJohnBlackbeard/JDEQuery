using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F90CA12A - .
/// </summary>
public class F90CA12A : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// IACIG.
        /// </summary>
        public const string IACIG = "IACIG";

        /// <summary>
        /// IAINDTRY.
        /// </summary>
        public const string IAINDTRY = "IAINDTRY";

        /// <summary>
        /// IAEXVAR0.
        /// </summary>
        public const string IAEXVAR0 = "IAEXVAR0";

        /// <summary>
        /// IAEXVAR1.
        /// </summary>
        public const string IAEXVAR1 = "IAEXVAR1";

        /// <summary>
        /// IAEXVAR2.
        /// </summary>
        public const string IAEXVAR2 = "IAEXVAR2";

        /// <summary>
        /// IAEXVAR3.
        /// </summary>
        public const string IAEXVAR3 = "IAEXVAR3";

        /// <summary>
        /// IAEXVAR4.
        /// </summary>
        public const string IAEXVAR4 = "IAEXVAR4";

        /// <summary>
        /// IAEXVAR5.
        /// </summary>
        public const string IAEXVAR5 = "IAEXVAR5";

        /// <summary>
        /// IAEXVAR6.
        /// </summary>
        public const string IAEXVAR6 = "IAEXVAR6";

        /// <summary>
        /// IAEXVAR7.
        /// </summary>
        public const string IAEXVAR7 = "IAEXVAR7";

        /// <summary>
        /// IAEXNM0.
        /// </summary>
        public const string IAEXNM0 = "IAEXNM0";

        /// <summary>
        /// IAEXNM1.
        /// </summary>
        public const string IAEXNM1 = "IAEXNM1";

        /// <summary>
        /// IAEXNM2.
        /// </summary>
        public const string IAEXNM2 = "IAEXNM2";

        /// <summary>
        /// IAEXNMP0.
        /// </summary>
        public const string IAEXNMP0 = "IAEXNMP0";

        /// <summary>
        /// IAEXNMP1.
        /// </summary>
        public const string IAEXNMP1 = "IAEXNMP1";

        /// <summary>
        /// IAEXNMP2.
        /// </summary>
        public const string IAEXNMP2 = "IAEXNMP2";

        /// <summary>
        /// IAEXDT0.
        /// </summary>
        public const string IAEXDT0 = "IAEXDT0";

        /// <summary>
        /// IAEXDT1.
        /// </summary>
        public const string IAEXDT1 = "IAEXDT1";

        /// <summary>
        /// IAEXDT2.
        /// </summary>
        public const string IAEXDT2 = "IAEXDT2";

        /// <summary>
        /// IAACTIND.
        /// </summary>
        public const string IAACTIND = "IAACTIND";

        /// <summary>
        /// IASTSUDT.
        /// </summary>
        public const string IASTSUDT = "IASTSUDT";

        /// <summary>
        /// IAUSER.
        /// </summary>
        public const string IAUSER = "IAUSER";

        /// <summary>
        /// IAPID.
        /// </summary>
        public const string IAPID = "IAPID";

        /// <summary>
        /// IAVID.
        /// </summary>
        public const string IAVID = "IAVID";

        /// <summary>
        /// IAENTDBY.
        /// </summary>
        public const string IAENTDBY = "IAENTDBY";

        /// <summary>
        /// IAEDATE.
        /// </summary>
        public const string IAEDATE = "IAEDATE";

        /// <summary>
        /// IAMKEY.
        /// </summary>
        public const string IAMKEY = "IAMKEY";

        /// <summary>
        /// IAUDTTM.
        /// </summary>
        public const string IAUDTTM = "IAUDTTM";
    }

    /// <inheritdoc />
    public override string TableName => "F90CA12A";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("IACIG", "IACIG", JdeDataType.Numeric, null, true, true),
        new JdeField("IAINDTRY", "IAINDTRY", JdeDataType.String, 20, true, true),
        new JdeField("IAEXVAR0", "IAEXVAR0", JdeDataType.String, 510),
        new JdeField("IAEXVAR1", "IAEXVAR1", JdeDataType.String, 510),
        new JdeField("IAEXVAR2", "IAEXVAR2", JdeDataType.String, 510),
        new JdeField("IAEXVAR3", "IAEXVAR3", JdeDataType.String, 510),
        new JdeField("IAEXVAR4", "IAEXVAR4", JdeDataType.String, 100),
        new JdeField("IAEXVAR5", "IAEXVAR5", JdeDataType.String, 100),
        new JdeField("IAEXVAR6", "IAEXVAR6", JdeDataType.String, 100),
        new JdeField("IAEXVAR7", "IAEXVAR7", JdeDataType.String, 100),
        new JdeField("IAEXNM0", "IAEXNM0", JdeDataType.Numeric),
        new JdeField("IAEXNM1", "IAEXNM1", JdeDataType.Numeric),
        new JdeField("IAEXNM2", "IAEXNM2", JdeDataType.Numeric),
        new JdeField("IAEXNMP0", "IAEXNMP0", JdeDataType.Numeric),
        new JdeField("IAEXNMP1", "IAEXNMP1", JdeDataType.Numeric),
        new JdeField("IAEXNMP2", "IAEXNMP2", JdeDataType.Numeric),
        new JdeField("IAEXDT0", "IAEXDT0", JdeDataType.Date),
        new JdeField("IAEXDT1", "IAEXDT1", JdeDataType.Date),
        new JdeField("IAEXDT2", "IAEXDT2", JdeDataType.Date),
        new JdeField("IAACTIND", "IAACTIND", JdeDataType.String, 2),
        new JdeField("IASTSUDT", "IASTSUDT", JdeDataType.Date),
        new JdeField("IAUSER", "IAUSER", JdeDataType.String, 20),
        new JdeField("IAPID", "IAPID", JdeDataType.String, 20),
        new JdeField("IAVID", "IAVID", JdeDataType.String, 20),
        new JdeField("IAENTDBY", "IAENTDBY", JdeDataType.Numeric),
        new JdeField("IAEDATE", "IAEDATE", JdeDataType.Date),
        new JdeField("IAMKEY", "IAMKEY", JdeDataType.String, 30),
        new JdeField("IAUDTTM", "IAUDTTM", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F90CA12A_0", "Primary Key on IACIG, IAINDTRY", new[] { "IACIG", "IAINDTRY" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F90CA12A_2", "Index on IAINDTRY", new[] { "IAINDTRY" })
    };
}
