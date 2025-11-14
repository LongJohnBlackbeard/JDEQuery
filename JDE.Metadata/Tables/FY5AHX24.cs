using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FY5AHX24 - .
/// </summary>
public class FY5AHX24 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SDY5AHE1RL.
        /// </summary>
        public const string SDY5AHE1RL = "SDY5AHE1RL";

        /// <summary>
        /// SDY5AHMDID.
        /// </summary>
        public const string SDY5AHMDID = "SDY5AHMDID";

        /// <summary>
        /// SDY5AHDTID.
        /// </summary>
        public const string SDY5AHDTID = "SDY5AHDTID";

        /// <summary>
        /// SDDS01.
        /// </summary>
        public const string SDDS01 = "SDDS01";

        /// <summary>
        /// SDUSER.
        /// </summary>
        public const string SDUSER = "SDUSER";

        /// <summary>
        /// SDPID.
        /// </summary>
        public const string SDPID = "SDPID";

        /// <summary>
        /// SDJOBN.
        /// </summary>
        public const string SDJOBN = "SDJOBN";

        /// <summary>
        /// SDUPMJ.
        /// </summary>
        public const string SDUPMJ = "SDUPMJ";

        /// <summary>
        /// SDUPMT.
        /// </summary>
        public const string SDUPMT = "SDUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "FY5AHX24";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SDY5AHE1RL", "SDY5AHE1RL", JdeDataType.String, 20, true, true),
        new JdeField("SDY5AHMDID", "SDY5AHMDID", JdeDataType.String, 20, true, true),
        new JdeField("SDY5AHDTID", "SDY5AHDTID", JdeDataType.String, 20, true, true),
        new JdeField("SDDS01", "SDDS01", JdeDataType.String, 160),
        new JdeField("SDUSER", "SDUSER", JdeDataType.String, 20),
        new JdeField("SDPID", "SDPID", JdeDataType.String, 20),
        new JdeField("SDJOBN", "SDJOBN", JdeDataType.String, 20),
        new JdeField("SDUPMJ", "SDUPMJ", JdeDataType.Numeric),
        new JdeField("SDUPMT", "SDUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FY5AHX24_0", "Primary Key on SDY5AHE1RL, SDY5AHMDID, SDY5AHDTID", new[] { "SDY5AHE1RL", "SDY5AHMDID", "SDY5AHDTID" }, isUnique: true, isPrimaryKey: true)
    };
}
