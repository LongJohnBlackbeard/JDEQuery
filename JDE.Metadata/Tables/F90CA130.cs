using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F90CA130 - .
/// </summary>
public class F90CA130 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BIINDTRY.
        /// </summary>
        public const string BIINDTRY = "BIINDTRY";

        /// <summary>
        /// BISNMB.
        /// </summary>
        public const string BISNMB = "BISNMB";

        /// <summary>
        /// BIORGRL.
        /// </summary>
        public const string BIORGRL = "BIORGRL";

        /// <summary>
        /// BIISTXT.
        /// </summary>
        public const string BIISTXT = "BIISTXT";

        /// <summary>
        /// BISVCTYP.
        /// </summary>
        public const string BISVCTYP = "BISVCTYP";

        /// <summary>
        /// BIEXVAR0.
        /// </summary>
        public const string BIEXVAR0 = "BIEXVAR0";

        /// <summary>
        /// BIEXVAR1.
        /// </summary>
        public const string BIEXVAR1 = "BIEXVAR1";

        /// <summary>
        /// BIEXVAR2.
        /// </summary>
        public const string BIEXVAR2 = "BIEXVAR2";

        /// <summary>
        /// BIEXVAR3.
        /// </summary>
        public const string BIEXVAR3 = "BIEXVAR3";

        /// <summary>
        /// BIEXVAR4.
        /// </summary>
        public const string BIEXVAR4 = "BIEXVAR4";

        /// <summary>
        /// BIEXVAR5.
        /// </summary>
        public const string BIEXVAR5 = "BIEXVAR5";

        /// <summary>
        /// BIEXVAR6.
        /// </summary>
        public const string BIEXVAR6 = "BIEXVAR6";

        /// <summary>
        /// BIEXVAR7.
        /// </summary>
        public const string BIEXVAR7 = "BIEXVAR7";

        /// <summary>
        /// BIEXNM0.
        /// </summary>
        public const string BIEXNM0 = "BIEXNM0";

        /// <summary>
        /// BIEXNM1.
        /// </summary>
        public const string BIEXNM1 = "BIEXNM1";

        /// <summary>
        /// BIEXNM2.
        /// </summary>
        public const string BIEXNM2 = "BIEXNM2";

        /// <summary>
        /// BIEXNMP0.
        /// </summary>
        public const string BIEXNMP0 = "BIEXNMP0";

        /// <summary>
        /// BIEXNMP1.
        /// </summary>
        public const string BIEXNMP1 = "BIEXNMP1";

        /// <summary>
        /// BIEXNMP2.
        /// </summary>
        public const string BIEXNMP2 = "BIEXNMP2";

        /// <summary>
        /// BIEXDT0.
        /// </summary>
        public const string BIEXDT0 = "BIEXDT0";

        /// <summary>
        /// BIEXDT1.
        /// </summary>
        public const string BIEXDT1 = "BIEXDT1";

        /// <summary>
        /// BIEXDT2.
        /// </summary>
        public const string BIEXDT2 = "BIEXDT2";

        /// <summary>
        /// BISTSUDT.
        /// </summary>
        public const string BISTSUDT = "BISTSUDT";

        /// <summary>
        /// BIACTIND.
        /// </summary>
        public const string BIACTIND = "BIACTIND";

        /// <summary>
        /// BIUSER.
        /// </summary>
        public const string BIUSER = "BIUSER";

        /// <summary>
        /// BIPID.
        /// </summary>
        public const string BIPID = "BIPID";

        /// <summary>
        /// BIEDATE.
        /// </summary>
        public const string BIEDATE = "BIEDATE";

        /// <summary>
        /// BIENTDBY.
        /// </summary>
        public const string BIENTDBY = "BIENTDBY";

        /// <summary>
        /// BIVID.
        /// </summary>
        public const string BIVID = "BIVID";

        /// <summary>
        /// BIMKEY.
        /// </summary>
        public const string BIMKEY = "BIMKEY";

        /// <summary>
        /// BIUDTTM.
        /// </summary>
        public const string BIUDTTM = "BIUDTTM";
    }

    /// <inheritdoc />
    public override string TableName => "F90CA130";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BIINDTRY", "BIINDTRY", JdeDataType.String, 20, true, true),
        new JdeField("BISNMB", "BISNMB", JdeDataType.Numeric, null, true, true),
        new JdeField("BIORGRL", "BIORGRL", JdeDataType.String, 10),
        new JdeField("BIISTXT", "BIISTXT", JdeDataType.String, 3000),
        new JdeField("BISVCTYP", "BISVCTYP", JdeDataType.String, 10),
        new JdeField("BIEXVAR0", "BIEXVAR0", JdeDataType.String, 510),
        new JdeField("BIEXVAR1", "BIEXVAR1", JdeDataType.String, 510),
        new JdeField("BIEXVAR2", "BIEXVAR2", JdeDataType.String, 510),
        new JdeField("BIEXVAR3", "BIEXVAR3", JdeDataType.String, 510),
        new JdeField("BIEXVAR4", "BIEXVAR4", JdeDataType.String, 100),
        new JdeField("BIEXVAR5", "BIEXVAR5", JdeDataType.String, 100),
        new JdeField("BIEXVAR6", "BIEXVAR6", JdeDataType.String, 100),
        new JdeField("BIEXVAR7", "BIEXVAR7", JdeDataType.String, 100),
        new JdeField("BIEXNM0", "BIEXNM0", JdeDataType.Numeric),
        new JdeField("BIEXNM1", "BIEXNM1", JdeDataType.Numeric),
        new JdeField("BIEXNM2", "BIEXNM2", JdeDataType.Numeric),
        new JdeField("BIEXNMP0", "BIEXNMP0", JdeDataType.Numeric),
        new JdeField("BIEXNMP1", "BIEXNMP1", JdeDataType.Numeric),
        new JdeField("BIEXNMP2", "BIEXNMP2", JdeDataType.Numeric),
        new JdeField("BIEXDT0", "BIEXDT0", JdeDataType.Date),
        new JdeField("BIEXDT1", "BIEXDT1", JdeDataType.Date),
        new JdeField("BIEXDT2", "BIEXDT2", JdeDataType.Date),
        new JdeField("BISTSUDT", "BISTSUDT", JdeDataType.Date),
        new JdeField("BIACTIND", "BIACTIND", JdeDataType.String, 2),
        new JdeField("BIUSER", "BIUSER", JdeDataType.String, 20),
        new JdeField("BIPID", "BIPID", JdeDataType.String, 20),
        new JdeField("BIEDATE", "BIEDATE", JdeDataType.Date),
        new JdeField("BIENTDBY", "BIENTDBY", JdeDataType.Numeric),
        new JdeField("BIVID", "BIVID", JdeDataType.String, 20),
        new JdeField("BIMKEY", "BIMKEY", JdeDataType.String, 30),
        new JdeField("BIUDTTM", "BIUDTTM", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F90CA130_0", "Primary Key on BIINDTRY, BISNMB", new[] { "BIINDTRY", "BISNMB" }, isUnique: true, isPrimaryKey: true)
    };
}
