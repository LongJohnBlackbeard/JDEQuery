using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75C002 - .
/// </summary>
public class F75C002 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// EAC75EBNO.
        /// </summary>
        public const string EAC75EBNO = "EAC75EBNO";

        /// <summary>
        /// EAC75ENAM.
        /// </summary>
        public const string EAC75ENAM = "EAC75ENAM";

        /// <summary>
        /// EAC75CNAM.
        /// </summary>
        public const string EAC75CNAM = "EAC75CNAM";

        /// <summary>
        /// EAC75OID.
        /// </summary>
        public const string EAC75OID = "EAC75OID";

        /// <summary>
        /// EAC75EQTY.
        /// </summary>
        public const string EAC75EQTY = "EAC75EQTY";

        /// <summary>
        /// EAC75EIND.
        /// </summary>
        public const string EAC75EIND = "EAC75EIND";

        /// <summary>
        /// EAC75ESW.
        /// </summary>
        public const string EAC75ESW = "EAC75ESW";

        /// <summary>
        /// EAC75SVER.
        /// </summary>
        public const string EAC75SVER = "EAC75SVER";

        /// <summary>
        /// EAFYR.
        /// </summary>
        public const string EAFYR = "EAFYR";

        /// <summary>
        /// EAC75FCUR.
        /// </summary>
        public const string EAC75FCUR = "EAC75FCUR";

        /// <summary>
        /// EAC75ACST.
        /// </summary>
        public const string EAC75ACST = "EAC75ACST";

        /// <summary>
        /// EAJOBN.
        /// </summary>
        public const string EAJOBN = "EAJOBN";

        /// <summary>
        /// EAPID.
        /// </summary>
        public const string EAPID = "EAPID";

        /// <summary>
        /// EAUSER.
        /// </summary>
        public const string EAUSER = "EAUSER";

        /// <summary>
        /// EAUPMJ.
        /// </summary>
        public const string EAUPMJ = "EAUPMJ";

        /// <summary>
        /// EAUPMT.
        /// </summary>
        public const string EAUPMT = "EAUPMT";

        /// <summary>
        /// EADL01.
        /// </summary>
        public const string EADL01 = "EADL01";

        /// <summary>
        /// EADL02.
        /// </summary>
        public const string EADL02 = "EADL02";

        /// <summary>
        /// EAMATH01.
        /// </summary>
        public const string EAMATH01 = "EAMATH01";

        /// <summary>
        /// EAMATH02.
        /// </summary>
        public const string EAMATH02 = "EAMATH02";

        /// <summary>
        /// EAFLAG.
        /// </summary>
        public const string EAFLAG = "EAFLAG";
    }

    /// <inheritdoc />
    public override string TableName => "F75C002";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("EAC75EBNO", "EAC75EBNO", JdeDataType.Numeric, null, true, true),
        new JdeField("EAC75ENAM", "EAC75ENAM", JdeDataType.String, 120),
        new JdeField("EAC75CNAM", "EAC75CNAM", JdeDataType.String, 120),
        new JdeField("EAC75OID", "EAC75OID", JdeDataType.String, 40),
        new JdeField("EAC75EQTY", "EAC75EQTY", JdeDataType.String, 16),
        new JdeField("EAC75EIND", "EAC75EIND", JdeDataType.String, 40),
        new JdeField("EAC75ESW", "EAC75ESW", JdeDataType.String, 120),
        new JdeField("EAC75SVER", "EAC75SVER", JdeDataType.String, 40),
        new JdeField("EAFYR", "EAFYR", JdeDataType.Numeric),
        new JdeField("EAC75FCUR", "EAC75FCUR", JdeDataType.String, 28),
        new JdeField("EAC75ACST", "EAC75ACST", JdeDataType.String, 120),
        new JdeField("EAJOBN", "EAJOBN", JdeDataType.String, 20),
        new JdeField("EAPID", "EAPID", JdeDataType.String, 20),
        new JdeField("EAUSER", "EAUSER", JdeDataType.String, 20),
        new JdeField("EAUPMJ", "EAUPMJ", JdeDataType.Numeric),
        new JdeField("EAUPMT", "EAUPMT", JdeDataType.Numeric),
        new JdeField("EADL01", "EADL01", JdeDataType.String, 60),
        new JdeField("EADL02", "EADL02", JdeDataType.String, 60),
        new JdeField("EAMATH01", "EAMATH01", JdeDataType.Numeric),
        new JdeField("EAMATH02", "EAMATH02", JdeDataType.Numeric),
        new JdeField("EAFLAG", "EAFLAG", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75C002_0", "Primary Key on EAC75EBNO", new[] { "EAC75EBNO" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F75C002_2", "Index on EAC75CNAM, EAC75OID, EAFYR", new[] { "EAC75CNAM", "EAC75OID", "EAFYR" })
    };
}
