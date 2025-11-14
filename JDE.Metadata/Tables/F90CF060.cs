using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F90CF060 - .
/// </summary>
public class F90CF060 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CCQUSTTYP.
        /// </summary>
        public const string CCQUSTTYP = "CCQUSTTYP";

        /// <summary>
        /// CCQUSTWGT.
        /// </summary>
        public const string CCQUSTWGT = "CCQUSTWGT";

        /// <summary>
        /// CCQUSTGUD.
        /// </summary>
        public const string CCQUSTGUD = "CCQUSTGUD";

        /// <summary>
        /// CCUSER.
        /// </summary>
        public const string CCUSER = "CCUSER";

        /// <summary>
        /// CCUDTTM.
        /// </summary>
        public const string CCUDTTM = "CCUDTTM";

        /// <summary>
        /// CCJOBN.
        /// </summary>
        public const string CCJOBN = "CCJOBN";

        /// <summary>
        /// CCMKEY.
        /// </summary>
        public const string CCMKEY = "CCMKEY";

        /// <summary>
        /// CCQUSTNME.
        /// </summary>
        public const string CCQUSTNME = "CCQUSTNME";

        /// <summary>
        /// CCQUSTID.
        /// </summary>
        public const string CCQUSTID = "CCQUSTID";

        /// <summary>
        /// CCVARLID.
        /// </summary>
        public const string CCVARLID = "CCVARLID";

        /// <summary>
        /// CCANSETID.
        /// </summary>
        public const string CCANSETID = "CCANSETID";

        /// <summary>
        /// CCQUSDESC.
        /// </summary>
        public const string CCQUSDESC = "CCQUSDESC";
    }

    /// <inheritdoc />
    public override string TableName => "F90CF060";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CCQUSTTYP", "CCQUSTTYP", JdeDataType.String, 2),
        new JdeField("CCQUSTWGT", "CCQUSTWGT", JdeDataType.Numeric),
        new JdeField("CCQUSTGUD", "CCQUSTGUD", JdeDataType.String, 510),
        new JdeField("CCUSER", "CCUSER", JdeDataType.String, 20),
        new JdeField("CCUDTTM", "CCUDTTM", JdeDataType.Date),
        new JdeField("CCJOBN", "CCJOBN", JdeDataType.String, 20),
        new JdeField("CCMKEY", "CCMKEY", JdeDataType.String, 30),
        new JdeField("CCQUSTNME", "CCQUSTNME", JdeDataType.String, 60),
        new JdeField("CCQUSTID", "CCQUSTID", JdeDataType.Numeric, null, true, true),
        new JdeField("CCVARLID", "CCVARLID", JdeDataType.Numeric),
        new JdeField("CCANSETID", "CCANSETID", JdeDataType.Numeric),
        new JdeField("CCQUSDESC", "CCQUSDESC", JdeDataType.String, 2000)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F90CF060_0", "Primary Key on CCQUSTID", new[] { "CCQUSTID" }, isUnique: true, isPrimaryKey: true)
    };
}
