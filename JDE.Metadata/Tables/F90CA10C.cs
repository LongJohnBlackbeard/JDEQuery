using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F90CA10C - .
/// </summary>
public class F90CA10C : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// IEITMHID.
        /// </summary>
        public const string IEITMHID = "IEITMHID";

        /// <summary>
        /// IEPSAN8.
        /// </summary>
        public const string IEPSAN8 = "IEPSAN8";

        /// <summary>
        /// IEENTDBY.
        /// </summary>
        public const string IEENTDBY = "IEENTDBY";

        /// <summary>
        /// IEMODB.
        /// </summary>
        public const string IEMODB = "IEMODB";

        /// <summary>
        /// IEEDATE.
        /// </summary>
        public const string IEEDATE = "IEEDATE";

        /// <summary>
        /// IEMDATE.
        /// </summary>
        public const string IEMDATE = "IEMDATE";

        /// <summary>
        /// IEEXVAR0.
        /// </summary>
        public const string IEEXVAR0 = "IEEXVAR0";

        /// <summary>
        /// IEEXVAR1.
        /// </summary>
        public const string IEEXVAR1 = "IEEXVAR1";

        /// <summary>
        /// IEEXVAR4.
        /// </summary>
        public const string IEEXVAR4 = "IEEXVAR4";

        /// <summary>
        /// IEEXVAR5.
        /// </summary>
        public const string IEEXVAR5 = "IEEXVAR5";

        /// <summary>
        /// IEEXVAR6.
        /// </summary>
        public const string IEEXVAR6 = "IEEXVAR6";

        /// <summary>
        /// IEEXVAR7.
        /// </summary>
        public const string IEEXVAR7 = "IEEXVAR7";

        /// <summary>
        /// IEEXVAR12.
        /// </summary>
        public const string IEEXVAR12 = "IEEXVAR12";

        /// <summary>
        /// IEEXVAR13.
        /// </summary>
        public const string IEEXVAR13 = "IEEXVAR13";

        /// <summary>
        /// IEEXNM0.
        /// </summary>
        public const string IEEXNM0 = "IEEXNM0";

        /// <summary>
        /// IEEXNM1.
        /// </summary>
        public const string IEEXNM1 = "IEEXNM1";

        /// <summary>
        /// IEEXNM2.
        /// </summary>
        public const string IEEXNM2 = "IEEXNM2";

        /// <summary>
        /// IEEXNMP0.
        /// </summary>
        public const string IEEXNMP0 = "IEEXNMP0";

        /// <summary>
        /// IEEXNMP1.
        /// </summary>
        public const string IEEXNMP1 = "IEEXNMP1";

        /// <summary>
        /// IEEXNMP2.
        /// </summary>
        public const string IEEXNMP2 = "IEEXNMP2";

        /// <summary>
        /// IEEXDT0.
        /// </summary>
        public const string IEEXDT0 = "IEEXDT0";

        /// <summary>
        /// IEEXDT1.
        /// </summary>
        public const string IEEXDT1 = "IEEXDT1";

        /// <summary>
        /// IEEXDT2.
        /// </summary>
        public const string IEEXDT2 = "IEEXDT2";

        /// <summary>
        /// IESTSUDT.
        /// </summary>
        public const string IESTSUDT = "IESTSUDT";

        /// <summary>
        /// IEACTIND.
        /// </summary>
        public const string IEACTIND = "IEACTIND";

        /// <summary>
        /// IEUSER.
        /// </summary>
        public const string IEUSER = "IEUSER";

        /// <summary>
        /// IEPID.
        /// </summary>
        public const string IEPID = "IEPID";

        /// <summary>
        /// IEVID.
        /// </summary>
        public const string IEVID = "IEVID";

        /// <summary>
        /// IEMKEY.
        /// </summary>
        public const string IEMKEY = "IEMKEY";

        /// <summary>
        /// IEUDTTM.
        /// </summary>
        public const string IEUDTTM = "IEUDTTM";
    }

    /// <inheritdoc />
    public override string TableName => "F90CA10C";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("IEITMHID", "IEITMHID", JdeDataType.Numeric, null, true, true),
        new JdeField("IEPSAN8", "IEPSAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("IEENTDBY", "IEENTDBY", JdeDataType.Numeric),
        new JdeField("IEMODB", "IEMODB", JdeDataType.Numeric),
        new JdeField("IEEDATE", "IEEDATE", JdeDataType.Date),
        new JdeField("IEMDATE", "IEMDATE", JdeDataType.Date),
        new JdeField("IEEXVAR0", "IEEXVAR0", JdeDataType.String, 510),
        new JdeField("IEEXVAR1", "IEEXVAR1", JdeDataType.String, 510),
        new JdeField("IEEXVAR4", "IEEXVAR4", JdeDataType.String, 100),
        new JdeField("IEEXVAR5", "IEEXVAR5", JdeDataType.String, 100),
        new JdeField("IEEXVAR6", "IEEXVAR6", JdeDataType.String, 100),
        new JdeField("IEEXVAR7", "IEEXVAR7", JdeDataType.String, 100),
        new JdeField("IEEXVAR12", "IEEXVAR12", JdeDataType.String, 50),
        new JdeField("IEEXVAR13", "IEEXVAR13", JdeDataType.String, 50),
        new JdeField("IEEXNM0", "IEEXNM0", JdeDataType.Numeric),
        new JdeField("IEEXNM1", "IEEXNM1", JdeDataType.Numeric),
        new JdeField("IEEXNM2", "IEEXNM2", JdeDataType.Numeric),
        new JdeField("IEEXNMP0", "IEEXNMP0", JdeDataType.Numeric),
        new JdeField("IEEXNMP1", "IEEXNMP1", JdeDataType.Numeric),
        new JdeField("IEEXNMP2", "IEEXNMP2", JdeDataType.Numeric),
        new JdeField("IEEXDT0", "IEEXDT0", JdeDataType.Date),
        new JdeField("IEEXDT1", "IEEXDT1", JdeDataType.Date),
        new JdeField("IEEXDT2", "IEEXDT2", JdeDataType.Date),
        new JdeField("IESTSUDT", "IESTSUDT", JdeDataType.Date),
        new JdeField("IEACTIND", "IEACTIND", JdeDataType.String, 2),
        new JdeField("IEUSER", "IEUSER", JdeDataType.String, 20),
        new JdeField("IEPID", "IEPID", JdeDataType.String, 20),
        new JdeField("IEVID", "IEVID", JdeDataType.String, 20),
        new JdeField("IEMKEY", "IEMKEY", JdeDataType.String, 30),
        new JdeField("IEUDTTM", "IEUDTTM", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F90CA10C_0", "Primary Key on IEITMHID, IEPSAN8", new[] { "IEITMHID", "IEPSAN8" }, isUnique: true, isPrimaryKey: true)
    };
}
