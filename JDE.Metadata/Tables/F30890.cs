using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F30890 - .
/// </summary>
public class F30890 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CCUKID.
        /// </summary>
        public const string CCUKID = "CCUKID";

        /// <summary>
        /// CCMCUFRM.
        /// </summary>
        public const string CCMCUFRM = "CCMCUFRM";

        /// <summary>
        /// CCMCUTO.
        /// </summary>
        public const string CCMCUTO = "CCMCUTO";

        /// <summary>
        /// CCUSER.
        /// </summary>
        public const string CCUSER = "CCUSER";

        /// <summary>
        /// CCPID.
        /// </summary>
        public const string CCPID = "CCPID";

        /// <summary>
        /// CCUPMJ.
        /// </summary>
        public const string CCUPMJ = "CCUPMJ";

        /// <summary>
        /// CCJOBN.
        /// </summary>
        public const string CCJOBN = "CCJOBN";

        /// <summary>
        /// CCUPMT.
        /// </summary>
        public const string CCUPMT = "CCUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F30890";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CCUKID", "CCUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("CCMCUFRM", "CCMCUFRM", JdeDataType.String, 24, true, true),
        new JdeField("CCMCUTO", "CCMCUTO", JdeDataType.String, 24, true, true),
        new JdeField("CCUSER", "CCUSER", JdeDataType.String, 20),
        new JdeField("CCPID", "CCPID", JdeDataType.String, 20),
        new JdeField("CCUPMJ", "CCUPMJ", JdeDataType.Numeric),
        new JdeField("CCJOBN", "CCJOBN", JdeDataType.String, 20),
        new JdeField("CCUPMT", "CCUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F30890_0", "Primary Key on CCUKID, CCMCUFRM, CCMCUTO", new[] { "CCUKID", "CCMCUFRM", "CCMCUTO" }, isUnique: true, isPrimaryKey: true)
    };
}
