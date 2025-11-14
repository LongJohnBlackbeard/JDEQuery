using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FY5AHX22 - .
/// </summary>
public class FY5AHX22 : JdeTable
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
        /// SDY5AHRLID.
        /// </summary>
        public const string SDY5AHRLID = "SDY5AHRLID";

        /// <summary>
        /// SDY5AHSDRT.
        /// </summary>
        public const string SDY5AHSDRT = "SDY5AHSDRT";

        /// <summary>
        /// SDDS01.
        /// </summary>
        public const string SDDS01 = "SDDS01";

        /// <summary>
        /// SDY5AHJFCD.
        /// </summary>
        public const string SDY5AHJFCD = "SDY5AHJFCD";

        /// <summary>
        /// SDY5AHJTXT.
        /// </summary>
        public const string SDY5AHJTXT = "SDY5AHJTXT";

        /// <summary>
        /// SDY5AHSLVL.
        /// </summary>
        public const string SDY5AHSLVL = "SDY5AHSLVL";

        /// <summary>
        /// SDY5AHRFDT.
        /// </summary>
        public const string SDY5AHRFDT = "SDY5AHRFDT";

        /// <summary>
        /// SDY5AHRTDT.
        /// </summary>
        public const string SDY5AHRTDT = "SDY5AHRTDT";

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
    public override string TableName => "FY5AHX22";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SDY5AHE1RL", "SDY5AHE1RL", JdeDataType.String, 20, true, true),
        new JdeField("SDY5AHMDID", "SDY5AHMDID", JdeDataType.String, 20, true, true),
        new JdeField("SDY5AHRLID", "SDY5AHRLID", JdeDataType.String, 20, true, true),
        new JdeField("SDY5AHSDRT", "SDY5AHSDRT", JdeDataType.String, 2),
        new JdeField("SDDS01", "SDDS01", JdeDataType.String, 160),
        new JdeField("SDY5AHJFCD", "SDY5AHJFCD", JdeDataType.String, 4),
        new JdeField("SDY5AHJTXT", "SDY5AHJTXT", JdeDataType.String, 160),
        new JdeField("SDY5AHSLVL", "SDY5AHSLVL", JdeDataType.String, 4),
        new JdeField("SDY5AHRFDT", "SDY5AHRFDT", JdeDataType.Numeric),
        new JdeField("SDY5AHRTDT", "SDY5AHRTDT", JdeDataType.Numeric),
        new JdeField("SDUSER", "SDUSER", JdeDataType.String, 20),
        new JdeField("SDPID", "SDPID", JdeDataType.String, 20),
        new JdeField("SDJOBN", "SDJOBN", JdeDataType.String, 20),
        new JdeField("SDUPMJ", "SDUPMJ", JdeDataType.Numeric),
        new JdeField("SDUPMT", "SDUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FY5AHX22_0", "Primary Key on SDY5AHE1RL, SDY5AHMDID, SDY5AHRLID", new[] { "SDY5AHE1RL", "SDY5AHMDID", "SDY5AHRLID" }, isUnique: true, isPrimaryKey: true)
    };
}
