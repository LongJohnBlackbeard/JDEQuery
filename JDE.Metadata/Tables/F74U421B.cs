using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74U421B - .
/// </summary>
public class F74U421B : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ADRPER.
        /// </summary>
        public const string ADRPER = "ADRPER";

        /// <summary>
        /// AD74UAP1.
        /// </summary>
        public const string AD74UAP1 = "AD74UAP1";

        /// <summary>
        /// ADEFFF.
        /// </summary>
        public const string ADEFFF = "ADEFFF";

        /// <summary>
        /// ADEFFT.
        /// </summary>
        public const string ADEFFT = "ADEFFT";

        /// <summary>
        /// ADUSER.
        /// </summary>
        public const string ADUSER = "ADUSER";

        /// <summary>
        /// ADPID.
        /// </summary>
        public const string ADPID = "ADPID";

        /// <summary>
        /// ADJOBN.
        /// </summary>
        public const string ADJOBN = "ADJOBN";

        /// <summary>
        /// ADUPMJ.
        /// </summary>
        public const string ADUPMJ = "ADUPMJ";

        /// <summary>
        /// ADUPMT.
        /// </summary>
        public const string ADUPMT = "ADUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F74U421B";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ADRPER", "ADRPER", JdeDataType.Numeric, null, true, true),
        new JdeField("AD74UAP1", "AD74UAP1", JdeDataType.Numeric, null, true, true),
        new JdeField("ADEFFF", "ADEFFF", JdeDataType.Numeric),
        new JdeField("ADEFFT", "ADEFFT", JdeDataType.Numeric),
        new JdeField("ADUSER", "ADUSER", JdeDataType.String, 20),
        new JdeField("ADPID", "ADPID", JdeDataType.String, 20),
        new JdeField("ADJOBN", "ADJOBN", JdeDataType.String, 20),
        new JdeField("ADUPMJ", "ADUPMJ", JdeDataType.Numeric),
        new JdeField("ADUPMT", "ADUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74U421B_0", "Primary Key on ADRPER, AD74UAP1", new[] { "ADRPER", "AD74UAP1" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F74U421B_2", "Index on AD74UAP1", new[] { "AD74UAP1" })
    };
}
