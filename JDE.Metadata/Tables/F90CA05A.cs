using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F90CA05A - .
/// </summary>
public class F90CA05A : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PAPRAN8.
        /// </summary>
        public const string PAPRAN8 = "PAPRAN8";

        /// <summary>
        /// PAEMAN8.
        /// </summary>
        public const string PAEMAN8 = "PAEMAN8";

        /// <summary>
        /// PARTYPE.
        /// </summary>
        public const string PARTYPE = "PARTYPE";

        /// <summary>
        /// PAENTDBY.
        /// </summary>
        public const string PAENTDBY = "PAENTDBY";

        /// <summary>
        /// PAMODB.
        /// </summary>
        public const string PAMODB = "PAMODB";

        /// <summary>
        /// PAEDATE.
        /// </summary>
        public const string PAEDATE = "PAEDATE";

        /// <summary>
        /// PAMDATE.
        /// </summary>
        public const string PAMDATE = "PAMDATE";

        /// <summary>
        /// PAEXVAR0.
        /// </summary>
        public const string PAEXVAR0 = "PAEXVAR0";

        /// <summary>
        /// PAEXVAR1.
        /// </summary>
        public const string PAEXVAR1 = "PAEXVAR1";

        /// <summary>
        /// PAEXVAR4.
        /// </summary>
        public const string PAEXVAR4 = "PAEXVAR4";

        /// <summary>
        /// PAEXVAR5.
        /// </summary>
        public const string PAEXVAR5 = "PAEXVAR5";

        /// <summary>
        /// PAEXVAR6.
        /// </summary>
        public const string PAEXVAR6 = "PAEXVAR6";

        /// <summary>
        /// PAEXVAR7.
        /// </summary>
        public const string PAEXVAR7 = "PAEXVAR7";

        /// <summary>
        /// PAEXVAR12.
        /// </summary>
        public const string PAEXVAR12 = "PAEXVAR12";

        /// <summary>
        /// PAEXVAR13.
        /// </summary>
        public const string PAEXVAR13 = "PAEXVAR13";

        /// <summary>
        /// PAEXNM0.
        /// </summary>
        public const string PAEXNM0 = "PAEXNM0";

        /// <summary>
        /// PAEXNM1.
        /// </summary>
        public const string PAEXNM1 = "PAEXNM1";

        /// <summary>
        /// PAEXNM2.
        /// </summary>
        public const string PAEXNM2 = "PAEXNM2";

        /// <summary>
        /// PAEXNMP0.
        /// </summary>
        public const string PAEXNMP0 = "PAEXNMP0";

        /// <summary>
        /// PAEXNMP1.
        /// </summary>
        public const string PAEXNMP1 = "PAEXNMP1";

        /// <summary>
        /// PAEXNMP2.
        /// </summary>
        public const string PAEXNMP2 = "PAEXNMP2";

        /// <summary>
        /// PAEXDT0.
        /// </summary>
        public const string PAEXDT0 = "PAEXDT0";

        /// <summary>
        /// PAEXDT1.
        /// </summary>
        public const string PAEXDT1 = "PAEXDT1";

        /// <summary>
        /// PAEXDT2.
        /// </summary>
        public const string PAEXDT2 = "PAEXDT2";

        /// <summary>
        /// PASTSUDT.
        /// </summary>
        public const string PASTSUDT = "PASTSUDT";

        /// <summary>
        /// PAACTIND.
        /// </summary>
        public const string PAACTIND = "PAACTIND";

        /// <summary>
        /// PAUSER.
        /// </summary>
        public const string PAUSER = "PAUSER";

        /// <summary>
        /// PAPID.
        /// </summary>
        public const string PAPID = "PAPID";

        /// <summary>
        /// PAVID.
        /// </summary>
        public const string PAVID = "PAVID";

        /// <summary>
        /// PAMKEY.
        /// </summary>
        public const string PAMKEY = "PAMKEY";

        /// <summary>
        /// PAUDTTM.
        /// </summary>
        public const string PAUDTTM = "PAUDTTM";
    }

    /// <inheritdoc />
    public override string TableName => "F90CA05A";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PAPRAN8", "PAPRAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("PAEMAN8", "PAEMAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("PARTYPE", "PARTYPE", JdeDataType.String, 10),
        new JdeField("PAENTDBY", "PAENTDBY", JdeDataType.Numeric),
        new JdeField("PAMODB", "PAMODB", JdeDataType.Numeric),
        new JdeField("PAEDATE", "PAEDATE", JdeDataType.Date),
        new JdeField("PAMDATE", "PAMDATE", JdeDataType.Date),
        new JdeField("PAEXVAR0", "PAEXVAR0", JdeDataType.String, 510),
        new JdeField("PAEXVAR1", "PAEXVAR1", JdeDataType.String, 510),
        new JdeField("PAEXVAR4", "PAEXVAR4", JdeDataType.String, 100),
        new JdeField("PAEXVAR5", "PAEXVAR5", JdeDataType.String, 100),
        new JdeField("PAEXVAR6", "PAEXVAR6", JdeDataType.String, 100),
        new JdeField("PAEXVAR7", "PAEXVAR7", JdeDataType.String, 100),
        new JdeField("PAEXVAR12", "PAEXVAR12", JdeDataType.String, 50),
        new JdeField("PAEXVAR13", "PAEXVAR13", JdeDataType.String, 50),
        new JdeField("PAEXNM0", "PAEXNM0", JdeDataType.Numeric),
        new JdeField("PAEXNM1", "PAEXNM1", JdeDataType.Numeric),
        new JdeField("PAEXNM2", "PAEXNM2", JdeDataType.Numeric),
        new JdeField("PAEXNMP0", "PAEXNMP0", JdeDataType.Numeric),
        new JdeField("PAEXNMP1", "PAEXNMP1", JdeDataType.Numeric),
        new JdeField("PAEXNMP2", "PAEXNMP2", JdeDataType.Numeric),
        new JdeField("PAEXDT0", "PAEXDT0", JdeDataType.Date),
        new JdeField("PAEXDT1", "PAEXDT1", JdeDataType.Date),
        new JdeField("PAEXDT2", "PAEXDT2", JdeDataType.Date),
        new JdeField("PASTSUDT", "PASTSUDT", JdeDataType.Date),
        new JdeField("PAACTIND", "PAACTIND", JdeDataType.String, 2),
        new JdeField("PAUSER", "PAUSER", JdeDataType.String, 20),
        new JdeField("PAPID", "PAPID", JdeDataType.String, 20),
        new JdeField("PAVID", "PAVID", JdeDataType.String, 20),
        new JdeField("PAMKEY", "PAMKEY", JdeDataType.String, 30),
        new JdeField("PAUDTTM", "PAUDTTM", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F90CA05A_0", "Primary Key on PAPRAN8, PAEMAN8", new[] { "PAPRAN8", "PAEMAN8" }, isUnique: true, isPrimaryKey: true)
    };
}
