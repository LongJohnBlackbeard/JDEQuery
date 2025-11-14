using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31B315 - .
/// </summary>
public class F31B315 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LOWLOTN.
        /// </summary>
        public const string LOWLOTN = "LOWLOTN";

        /// <summary>
        /// LOMCU.
        /// </summary>
        public const string LOMCU = "LOMCU";

        /// <summary>
        /// LOOWNRCOD.
        /// </summary>
        public const string LOOWNRCOD = "LOOWNRCOD";

        /// <summary>
        /// LOBFLG.
        /// </summary>
        public const string LOBFLG = "LOBFLG";

        /// <summary>
        /// LOLTQNTY.
        /// </summary>
        public const string LOLTQNTY = "LOLTQNTY";

        /// <summary>
        /// LOPERCT.
        /// </summary>
        public const string LOPERCT = "LOPERCT";

        /// <summary>
        /// LOUSER.
        /// </summary>
        public const string LOUSER = "LOUSER";

        /// <summary>
        /// LOJOBN.
        /// </summary>
        public const string LOJOBN = "LOJOBN";

        /// <summary>
        /// LOPID.
        /// </summary>
        public const string LOPID = "LOPID";

        /// <summary>
        /// LOUPMJ.
        /// </summary>
        public const string LOUPMJ = "LOUPMJ";

        /// <summary>
        /// LOUPMT.
        /// </summary>
        public const string LOUPMT = "LOUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F31B315";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LOWLOTN", "LOWLOTN", JdeDataType.String, 60, true, true),
        new JdeField("LOMCU", "LOMCU", JdeDataType.String, 24, true, true),
        new JdeField("LOOWNRCOD", "LOOWNRCOD", JdeDataType.String, 12, true, true),
        new JdeField("LOBFLG", "LOBFLG", JdeDataType.String, 2, true, true),
        new JdeField("LOLTQNTY", "LOLTQNTY", JdeDataType.Numeric),
        new JdeField("LOPERCT", "LOPERCT", JdeDataType.Numeric),
        new JdeField("LOUSER", "LOUSER", JdeDataType.String, 20),
        new JdeField("LOJOBN", "LOJOBN", JdeDataType.String, 20),
        new JdeField("LOPID", "LOPID", JdeDataType.String, 20),
        new JdeField("LOUPMJ", "LOUPMJ", JdeDataType.Numeric),
        new JdeField("LOUPMT", "LOUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31B315_0", "Primary Key on LOWLOTN, LOMCU, LOOWNRCOD, LOBFLG", new[] { "LOWLOTN", "LOMCU", "LOOWNRCOD", "LOBFLG" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F31B315_2", "Index on LOWLOTN, LOMCU", new[] { "LOWLOTN", "LOMCU" }),
        new JdeIndex("F31B315_3", "Index on LOOWNRCOD", new[] { "LOOWNRCOD" })
    };
}
