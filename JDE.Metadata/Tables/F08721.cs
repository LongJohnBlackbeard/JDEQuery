using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F08721 - .
/// </summary>
public class F08721 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SDSTCI.
        /// </summary>
        public const string SDSTCI = "SDSTCI";

        /// <summary>
        /// SDDTAI.
        /// </summary>
        public const string SDDTAI = "SDDTAI";

        /// <summary>
        /// SDOLDVAL.
        /// </summary>
        public const string SDOLDVAL = "SDOLDVAL";

        /// <summary>
        /// SDNEWVAL.
        /// </summary>
        public const string SDNEWVAL = "SDNEWVAL";

        /// <summary>
        /// SDUPMJ.
        /// </summary>
        public const string SDUPMJ = "SDUPMJ";

        /// <summary>
        /// SDUPMT.
        /// </summary>
        public const string SDUPMT = "SDUPMT";

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
        /// SDSTCTY.
        /// </summary>
        public const string SDSTCTY = "SDSTCTY";
    }

    /// <inheritdoc />
    public override string TableName => "F08721";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SDSTCI", "SDSTCI", JdeDataType.Numeric, null, true, true),
        new JdeField("SDDTAI", "SDDTAI", JdeDataType.String, 20, true, true),
        new JdeField("SDOLDVAL", "SDOLDVAL", JdeDataType.String, 40),
        new JdeField("SDNEWVAL", "SDNEWVAL", JdeDataType.String, 40),
        new JdeField("SDUPMJ", "SDUPMJ", JdeDataType.Numeric),
        new JdeField("SDUPMT", "SDUPMT", JdeDataType.Numeric),
        new JdeField("SDUSER", "SDUSER", JdeDataType.String, 20),
        new JdeField("SDPID", "SDPID", JdeDataType.String, 20),
        new JdeField("SDJOBN", "SDJOBN", JdeDataType.String, 20),
        new JdeField("SDSTCTY", "SDSTCTY", JdeDataType.String, 16, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F08721_0", "Primary Key on SDSTCI, SDSTCTY, SDDTAI", new[] { "SDSTCI", "SDSTCTY", "SDDTAI" }, isUnique: true, isPrimaryKey: true)
    };
}
