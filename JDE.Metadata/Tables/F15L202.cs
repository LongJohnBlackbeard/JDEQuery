using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F15L202 - .
/// </summary>
public class F15L202 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ASMCU.
        /// </summary>
        public const string ASMCU = "ASMCU";

        /// <summary>
        /// ASRVNB.
        /// </summary>
        public const string ASRVNB = "ASRVNB";

        /// <summary>
        /// ASPLTYP.
        /// </summary>
        public const string ASPLTYP = "ASPLTYP";

        /// <summary>
        /// ASARVNB.
        /// </summary>
        public const string ASARVNB = "ASARVNB";

        /// <summary>
        /// ASPLNME.
        /// </summary>
        public const string ASPLNME = "ASPLNME";

        /// <summary>
        /// ASUSER.
        /// </summary>
        public const string ASUSER = "ASUSER";

        /// <summary>
        /// ASPID.
        /// </summary>
        public const string ASPID = "ASPID";

        /// <summary>
        /// ASMKEY.
        /// </summary>
        public const string ASMKEY = "ASMKEY";

        /// <summary>
        /// ASUPMJ.
        /// </summary>
        public const string ASUPMJ = "ASUPMJ";

        /// <summary>
        /// ASUPMT.
        /// </summary>
        public const string ASUPMT = "ASUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F15L202";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ASMCU", "ASMCU", JdeDataType.String, 24, true, true),
        new JdeField("ASRVNB", "ASRVNB", JdeDataType.Numeric, null, true, true),
        new JdeField("ASPLTYP", "ASPLTYP", JdeDataType.String, 2, true, true),
        new JdeField("ASARVNB", "ASARVNB", JdeDataType.String, 2, true, true),
        new JdeField("ASPLNME", "ASPLNME", JdeDataType.String, 30),
        new JdeField("ASUSER", "ASUSER", JdeDataType.String, 20),
        new JdeField("ASPID", "ASPID", JdeDataType.String, 20),
        new JdeField("ASMKEY", "ASMKEY", JdeDataType.String, 30),
        new JdeField("ASUPMJ", "ASUPMJ", JdeDataType.Numeric),
        new JdeField("ASUPMT", "ASUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F15L202_0", "Primary Key on ASMCU, ASRVNB, ASPLTYP, ASARVNB", new[] { "ASMCU", "ASRVNB", "ASPLTYP", "ASARVNB" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F15L202_3", "Index on ASPLNME", new[] { "ASPLNME" }),
        new JdeIndex("F15L202_4", "Index on ASPLTYP", new[] { "ASPLTYP" })
    };
}
