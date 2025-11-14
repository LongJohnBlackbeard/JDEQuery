using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F90CB041 - .
/// </summary>
public class F90CB041 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// QAQA8.
        /// </summary>
        public const string QAQA8 = "QAQA8";

        /// <summary>
        /// QAQQ8.
        /// </summary>
        public const string QAQQ8 = "QAQQ8";

        /// <summary>
        /// QAQASE.
        /// </summary>
        public const string QAQASE = "QAQASE";

        /// <summary>
        /// QAQLAV.
        /// </summary>
        public const string QAQLAV = "QAQLAV";

        /// <summary>
        /// QAMDATE.
        /// </summary>
        public const string QAMDATE = "QAMDATE";

        /// <summary>
        /// QAEDATE.
        /// </summary>
        public const string QAEDATE = "QAEDATE";

        /// <summary>
        /// QAMODBY.
        /// </summary>
        public const string QAMODBY = "QAMODBY";

        /// <summary>
        /// QAENTDBY.
        /// </summary>
        public const string QAENTDBY = "QAENTDBY";

        /// <summary>
        /// QAQLWV.
        /// </summary>
        public const string QAQLWV = "QAQLWV";

        /// <summary>
        /// QAMKEY.
        /// </summary>
        public const string QAMKEY = "QAMKEY";

        /// <summary>
        /// QAVID.
        /// </summary>
        public const string QAVID = "QAVID";

        /// <summary>
        /// QAUSER.
        /// </summary>
        public const string QAUSER = "QAUSER";

        /// <summary>
        /// QAUDTTM.
        /// </summary>
        public const string QAUDTTM = "QAUDTTM";

        /// <summary>
        /// QAPID.
        /// </summary>
        public const string QAPID = "QAPID";

        /// <summary>
        /// QAUPMT.
        /// </summary>
        public const string QAUPMT = "QAUPMT";

        /// <summary>
        /// QAEXVAR0.
        /// </summary>
        public const string QAEXVAR0 = "QAEXVAR0";

        /// <summary>
        /// QAEXVAR1.
        /// </summary>
        public const string QAEXVAR1 = "QAEXVAR1";

        /// <summary>
        /// QAEXVAR2.
        /// </summary>
        public const string QAEXVAR2 = "QAEXVAR2";

        /// <summary>
        /// QAEXVAR3.
        /// </summary>
        public const string QAEXVAR3 = "QAEXVAR3";

        /// <summary>
        /// QAEXVAR4.
        /// </summary>
        public const string QAEXVAR4 = "QAEXVAR4";

        /// <summary>
        /// QAEXVAR5.
        /// </summary>
        public const string QAEXVAR5 = "QAEXVAR5";

        /// <summary>
        /// QAEXVAR6.
        /// </summary>
        public const string QAEXVAR6 = "QAEXVAR6";

        /// <summary>
        /// QAEXVAR7.
        /// </summary>
        public const string QAEXVAR7 = "QAEXVAR7";

        /// <summary>
        /// QAEXDT0.
        /// </summary>
        public const string QAEXDT0 = "QAEXDT0";

        /// <summary>
        /// QAEXDT1.
        /// </summary>
        public const string QAEXDT1 = "QAEXDT1";

        /// <summary>
        /// QAEXDT2.
        /// </summary>
        public const string QAEXDT2 = "QAEXDT2";

        /// <summary>
        /// QAEXNM0.
        /// </summary>
        public const string QAEXNM0 = "QAEXNM0";

        /// <summary>
        /// QAEXNM1.
        /// </summary>
        public const string QAEXNM1 = "QAEXNM1";

        /// <summary>
        /// QAEXNM2.
        /// </summary>
        public const string QAEXNM2 = "QAEXNM2";

        /// <summary>
        /// QAEXNMP0.
        /// </summary>
        public const string QAEXNMP0 = "QAEXNMP0";

        /// <summary>
        /// QAEXNMP1.
        /// </summary>
        public const string QAEXNMP1 = "QAEXNMP1";

        /// <summary>
        /// QAEXNMP2.
        /// </summary>
        public const string QAEXNMP2 = "QAEXNMP2";

        /// <summary>
        /// QAACTIND.
        /// </summary>
        public const string QAACTIND = "QAACTIND";

        /// <summary>
        /// QASTSUDT.
        /// </summary>
        public const string QASTSUDT = "QASTSUDT";
    }

    /// <inheritdoc />
    public override string TableName => "F90CB041";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("QAQA8", "QAQA8", JdeDataType.Numeric, null, true, true),
        new JdeField("QAQQ8", "QAQQ8", JdeDataType.Numeric),
        new JdeField("QAQASE", "QAQASE", JdeDataType.Numeric),
        new JdeField("QAQLAV", "QAQLAV", JdeDataType.String, 3998),
        new JdeField("QAMDATE", "QAMDATE", JdeDataType.Date),
        new JdeField("QAEDATE", "QAEDATE", JdeDataType.Date),
        new JdeField("QAMODBY", "QAMODBY", JdeDataType.String, 20),
        new JdeField("QAENTDBY", "QAENTDBY", JdeDataType.Numeric),
        new JdeField("QAQLWV", "QAQLWV", JdeDataType.Numeric),
        new JdeField("QAMKEY", "QAMKEY", JdeDataType.String, 30),
        new JdeField("QAVID", "QAVID", JdeDataType.String, 20),
        new JdeField("QAUSER", "QAUSER", JdeDataType.String, 20),
        new JdeField("QAUDTTM", "QAUDTTM", JdeDataType.Date),
        new JdeField("QAPID", "QAPID", JdeDataType.String, 20),
        new JdeField("QAUPMT", "QAUPMT", JdeDataType.Numeric),
        new JdeField("QAEXVAR0", "QAEXVAR0", JdeDataType.String, 510),
        new JdeField("QAEXVAR1", "QAEXVAR1", JdeDataType.String, 510),
        new JdeField("QAEXVAR2", "QAEXVAR2", JdeDataType.String, 510),
        new JdeField("QAEXVAR3", "QAEXVAR3", JdeDataType.String, 510),
        new JdeField("QAEXVAR4", "QAEXVAR4", JdeDataType.String, 100),
        new JdeField("QAEXVAR5", "QAEXVAR5", JdeDataType.String, 100),
        new JdeField("QAEXVAR6", "QAEXVAR6", JdeDataType.String, 100),
        new JdeField("QAEXVAR7", "QAEXVAR7", JdeDataType.String, 100),
        new JdeField("QAEXDT0", "QAEXDT0", JdeDataType.Date),
        new JdeField("QAEXDT1", "QAEXDT1", JdeDataType.Date),
        new JdeField("QAEXDT2", "QAEXDT2", JdeDataType.Date),
        new JdeField("QAEXNM0", "QAEXNM0", JdeDataType.Numeric),
        new JdeField("QAEXNM1", "QAEXNM1", JdeDataType.Numeric),
        new JdeField("QAEXNM2", "QAEXNM2", JdeDataType.Numeric),
        new JdeField("QAEXNMP0", "QAEXNMP0", JdeDataType.Numeric),
        new JdeField("QAEXNMP1", "QAEXNMP1", JdeDataType.Numeric),
        new JdeField("QAEXNMP2", "QAEXNMP2", JdeDataType.Numeric),
        new JdeField("QAACTIND", "QAACTIND", JdeDataType.String, 2),
        new JdeField("QASTSUDT", "QASTSUDT", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F90CB041_0", "Primary Key on QAQA8", new[] { "QAQA8" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F90CB041_2", "Index on QAQQ8", new[] { "QAQQ8" })
    };
}
