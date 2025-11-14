using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1603 - .
/// </summary>
public class F1603 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CVVWNM.
        /// </summary>
        public const string CVVWNM = "CVVWNM";

        /// <summary>
        /// CVDL01.
        /// </summary>
        public const string CVDL01 = "CVDL01";

        /// <summary>
        /// CVVW01.
        /// </summary>
        public const string CVVW01 = "CVVW01";

        /// <summary>
        /// CVVW02.
        /// </summary>
        public const string CVVW02 = "CVVW02";

        /// <summary>
        /// CVVW03.
        /// </summary>
        public const string CVVW03 = "CVVW03";

        /// <summary>
        /// CVVW04.
        /// </summary>
        public const string CVVW04 = "CVVW04";

        /// <summary>
        /// CVVW05.
        /// </summary>
        public const string CVVW05 = "CVVW05";

        /// <summary>
        /// CVVW06.
        /// </summary>
        public const string CVVW06 = "CVVW06";

        /// <summary>
        /// CVVW07.
        /// </summary>
        public const string CVVW07 = "CVVW07";

        /// <summary>
        /// CVVW08.
        /// </summary>
        public const string CVVW08 = "CVVW08";

        /// <summary>
        /// CVVW09.
        /// </summary>
        public const string CVVW09 = "CVVW09";

        /// <summary>
        /// CVVW10.
        /// </summary>
        public const string CVVW10 = "CVVW10";

        /// <summary>
        /// CVVW11.
        /// </summary>
        public const string CVVW11 = "CVVW11";

        /// <summary>
        /// CVLT.
        /// </summary>
        public const string CVLT = "CVLT";

        /// <summary>
        /// CVFY.
        /// </summary>
        public const string CVFY = "CVFY";

        /// <summary>
        /// CVDTPN.
        /// </summary>
        public const string CVDTPN = "CVDTPN";

        /// <summary>
        /// CVMCU.
        /// </summary>
        public const string CVMCU = "CVMCU";

        /// <summary>
        /// CVOBJ.
        /// </summary>
        public const string CVOBJ = "CVOBJ";

        /// <summary>
        /// CVSUB.
        /// </summary>
        public const string CVSUB = "CVSUB";

        /// <summary>
        /// CVEV01.
        /// </summary>
        public const string CVEV01 = "CVEV01";

        /// <summary>
        /// CVUSER.
        /// </summary>
        public const string CVUSER = "CVUSER";

        /// <summary>
        /// CVPID.
        /// </summary>
        public const string CVPID = "CVPID";

        /// <summary>
        /// CVUPMJ.
        /// </summary>
        public const string CVUPMJ = "CVUPMJ";

        /// <summary>
        /// CVUPMT.
        /// </summary>
        public const string CVUPMT = "CVUPMT";

        /// <summary>
        /// CVJOBN.
        /// </summary>
        public const string CVJOBN = "CVJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F1603";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CVVWNM", "CVVWNM", JdeDataType.Numeric, null, true, true),
        new JdeField("CVDL01", "CVDL01", JdeDataType.String, 60),
        new JdeField("CVVW01", "CVVW01", JdeDataType.String, 2),
        new JdeField("CVVW02", "CVVW02", JdeDataType.String, 2),
        new JdeField("CVVW03", "CVVW03", JdeDataType.String, 2),
        new JdeField("CVVW04", "CVVW04", JdeDataType.String, 2),
        new JdeField("CVVW05", "CVVW05", JdeDataType.String, 2),
        new JdeField("CVVW06", "CVVW06", JdeDataType.String, 2),
        new JdeField("CVVW07", "CVVW07", JdeDataType.String, 2),
        new JdeField("CVVW08", "CVVW08", JdeDataType.String, 2),
        new JdeField("CVVW09", "CVVW09", JdeDataType.String, 2),
        new JdeField("CVVW10", "CVVW10", JdeDataType.String, 2),
        new JdeField("CVVW11", "CVVW11", JdeDataType.String, 2),
        new JdeField("CVLT", "CVLT", JdeDataType.String, 4),
        new JdeField("CVFY", "CVFY", JdeDataType.Numeric, null, true, true),
        new JdeField("CVDTPN", "CVDTPN", JdeDataType.String, 2),
        new JdeField("CVMCU", "CVMCU", JdeDataType.String, 24),
        new JdeField("CVOBJ", "CVOBJ", JdeDataType.String, 12),
        new JdeField("CVSUB", "CVSUB", JdeDataType.String, 16),
        new JdeField("CVEV01", "CVEV01", JdeDataType.String, 2),
        new JdeField("CVUSER", "CVUSER", JdeDataType.String, 20),
        new JdeField("CVPID", "CVPID", JdeDataType.String, 20),
        new JdeField("CVUPMJ", "CVUPMJ", JdeDataType.Numeric),
        new JdeField("CVUPMT", "CVUPMT", JdeDataType.Numeric),
        new JdeField("CVJOBN", "CVJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1603_0", "Primary Key on CVVWNM, CVFY", new[] { "CVVWNM", "CVFY" }, isUnique: true, isPrimaryKey: true)
    };
}
