using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31B12 - .
/// </summary>
public class F31B12 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PAWAID.
        /// </summary>
        public const string PAWAID = "PAWAID";

        /// <summary>
        /// PAWANA.
        /// </summary>
        public const string PAWANA = "PAWANA";

        /// <summary>
        /// PAMCU.
        /// </summary>
        public const string PAMCU = "PAMCU";

        /// <summary>
        /// PAWAST.
        /// </summary>
        public const string PAWAST = "PAWAST";

        /// <summary>
        /// PAWAC1.
        /// </summary>
        public const string PAWAC1 = "PAWAC1";

        /// <summary>
        /// PAWAC2.
        /// </summary>
        public const string PAWAC2 = "PAWAC2";

        /// <summary>
        /// PAWAC3.
        /// </summary>
        public const string PAWAC3 = "PAWAC3";

        /// <summary>
        /// PAWAC4.
        /// </summary>
        public const string PAWAC4 = "PAWAC4";

        /// <summary>
        /// PAWAC5.
        /// </summary>
        public const string PAWAC5 = "PAWAC5";

        /// <summary>
        /// PAWACP1.
        /// </summary>
        public const string PAWACP1 = "PAWACP1";

        /// <summary>
        /// PAWACP2.
        /// </summary>
        public const string PAWACP2 = "PAWACP2";

        /// <summary>
        /// PAWACP3.
        /// </summary>
        public const string PAWACP3 = "PAWACP3";

        /// <summary>
        /// PAWACP4.
        /// </summary>
        public const string PAWACP4 = "PAWACP4";

        /// <summary>
        /// PAWACP5.
        /// </summary>
        public const string PAWACP5 = "PAWACP5";

        /// <summary>
        /// PAWACP6.
        /// </summary>
        public const string PAWACP6 = "PAWACP6";

        /// <summary>
        /// PAWACP7.
        /// </summary>
        public const string PAWACP7 = "PAWACP7";

        /// <summary>
        /// PAWACP8.
        /// </summary>
        public const string PAWACP8 = "PAWACP8";

        /// <summary>
        /// PAWACP9.
        /// </summary>
        public const string PAWACP9 = "PAWACP9";

        /// <summary>
        /// PAWACP10.
        /// </summary>
        public const string PAWACP10 = "PAWACP10";

        /// <summary>
        /// PAUSER.
        /// </summary>
        public const string PAUSER = "PAUSER";

        /// <summary>
        /// PAPID.
        /// </summary>
        public const string PAPID = "PAPID";

        /// <summary>
        /// PAJOBN.
        /// </summary>
        public const string PAJOBN = "PAJOBN";

        /// <summary>
        /// PAUPMJ.
        /// </summary>
        public const string PAUPMJ = "PAUPMJ";

        /// <summary>
        /// PAUPMT.
        /// </summary>
        public const string PAUPMT = "PAUPMT";

        /// <summary>
        /// PAURCD.
        /// </summary>
        public const string PAURCD = "PAURCD";

        /// <summary>
        /// PAURDT.
        /// </summary>
        public const string PAURDT = "PAURDT";

        /// <summary>
        /// PAURAT.
        /// </summary>
        public const string PAURAT = "PAURAT";

        /// <summary>
        /// PAURRF.
        /// </summary>
        public const string PAURRF = "PAURRF";

        /// <summary>
        /// PAURAB.
        /// </summary>
        public const string PAURAB = "PAURAB";
    }

    /// <inheritdoc />
    public override string TableName => "F31B12";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PAWAID", "PAWAID", JdeDataType.String, 16, true, true),
        new JdeField("PAWANA", "PAWANA", JdeDataType.String, 60),
        new JdeField("PAMCU", "PAMCU", JdeDataType.String, 24),
        new JdeField("PAWAST", "PAWAST", JdeDataType.String, 2),
        new JdeField("PAWAC1", "PAWAC1", JdeDataType.String, 6),
        new JdeField("PAWAC2", "PAWAC2", JdeDataType.String, 6),
        new JdeField("PAWAC3", "PAWAC3", JdeDataType.String, 6),
        new JdeField("PAWAC4", "PAWAC4", JdeDataType.String, 6),
        new JdeField("PAWAC5", "PAWAC5", JdeDataType.String, 6),
        new JdeField("PAWACP1", "PAWACP1", JdeDataType.String, 20),
        new JdeField("PAWACP2", "PAWACP2", JdeDataType.String, 20),
        new JdeField("PAWACP3", "PAWACP3", JdeDataType.String, 20),
        new JdeField("PAWACP4", "PAWACP4", JdeDataType.String, 20),
        new JdeField("PAWACP5", "PAWACP5", JdeDataType.String, 20),
        new JdeField("PAWACP6", "PAWACP6", JdeDataType.String, 20),
        new JdeField("PAWACP7", "PAWACP7", JdeDataType.String, 20),
        new JdeField("PAWACP8", "PAWACP8", JdeDataType.String, 20),
        new JdeField("PAWACP9", "PAWACP9", JdeDataType.String, 20),
        new JdeField("PAWACP10", "PAWACP10", JdeDataType.String, 20),
        new JdeField("PAUSER", "PAUSER", JdeDataType.String, 20),
        new JdeField("PAPID", "PAPID", JdeDataType.String, 20),
        new JdeField("PAJOBN", "PAJOBN", JdeDataType.String, 20),
        new JdeField("PAUPMJ", "PAUPMJ", JdeDataType.Numeric),
        new JdeField("PAUPMT", "PAUPMT", JdeDataType.Numeric),
        new JdeField("PAURCD", "PAURCD", JdeDataType.String, 4),
        new JdeField("PAURDT", "PAURDT", JdeDataType.Numeric),
        new JdeField("PAURAT", "PAURAT", JdeDataType.Numeric),
        new JdeField("PAURRF", "PAURRF", JdeDataType.String, 30),
        new JdeField("PAURAB", "PAURAB", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31B12_0", "Primary Key on PAWAID", new[] { "PAWAID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F31B12_2", "Index on PAMCU, PAWAID", new[] { "PAMCU", "PAWAID" })
    };
}
