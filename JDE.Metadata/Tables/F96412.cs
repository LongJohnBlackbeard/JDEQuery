using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F96412 - .
/// </summary>
public class F96412 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// FESUTYPE.
        /// </summary>
        public const string FESUTYPE = "FESUTYPE";

        /// <summary>
        /// FEHOSTTYPE.
        /// </summary>
        public const string FEHOSTTYPE = "FEHOSTTYPE";

        /// <summary>
        /// FESUFILETY.
        /// </summary>
        public const string FESUFILETY = "FESUFILETY";

        /// <summary>
        /// FEESUP.
        /// </summary>
        public const string FEESUP = "FEESUP";

        /// <summary>
        /// FESUFILEEX.
        /// </summary>
        public const string FESUFILEEX = "FESUFILEEX";

        /// <summary>
        /// FESUFRPATH.
        /// </summary>
        public const string FESUFRPATH = "FESUFRPATH";

        /// <summary>
        /// FESUTOPATH.
        /// </summary>
        public const string FESUTOPATH = "FESUTOPATH";

        /// <summary>
        /// FESUFUSTR.
        /// </summary>
        public const string FESUFUSTR = "FESUFUSTR";

        /// <summary>
        /// FESUFUSTR2.
        /// </summary>
        public const string FESUFUSTR2 = "FESUFUSTR2";

        /// <summary>
        /// FESUFUNM1.
        /// </summary>
        public const string FESUFUNM1 = "FESUFUNM1";

        /// <summary>
        /// FESUFUNM2.
        /// </summary>
        public const string FESUFUNM2 = "FESUFUNM2";

        /// <summary>
        /// FESUFUUPMJ.
        /// </summary>
        public const string FESUFUUPMJ = "FESUFUUPMJ";

        /// <summary>
        /// FESUFUUPMT.
        /// </summary>
        public const string FESUFUUPMT = "FESUFUUPMT";

        /// <summary>
        /// FEUSER.
        /// </summary>
        public const string FEUSER = "FEUSER";

        /// <summary>
        /// FEUPMJ.
        /// </summary>
        public const string FEUPMJ = "FEUPMJ";

        /// <summary>
        /// FEJOBN.
        /// </summary>
        public const string FEJOBN = "FEJOBN";

        /// <summary>
        /// FEUPMT.
        /// </summary>
        public const string FEUPMT = "FEUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F96412";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("FESUTYPE", "FESUTYPE", JdeDataType.String, 4, true, true),
        new JdeField("FEHOSTTYPE", "FEHOSTTYPE", JdeDataType.String, 4, true, true),
        new JdeField("FESUFILETY", "FESUFILETY", JdeDataType.String, 4, true, true),
        new JdeField("FEESUP", "FEESUP", JdeDataType.String, 20, true, true),
        new JdeField("FESUFILEEX", "FESUFILEEX", JdeDataType.String, 8),
        new JdeField("FESUFRPATH", "FESUFRPATH", JdeDataType.String, 510),
        new JdeField("FESUTOPATH", "FESUTOPATH", JdeDataType.String, 510),
        new JdeField("FESUFUSTR", "FESUFUSTR", JdeDataType.String, 60),
        new JdeField("FESUFUSTR2", "FESUFUSTR2", JdeDataType.String, 60),
        new JdeField("FESUFUNM1", "FESUFUNM1", JdeDataType.Numeric),
        new JdeField("FESUFUNM2", "FESUFUNM2", JdeDataType.Numeric),
        new JdeField("FESUFUUPMJ", "FESUFUUPMJ", JdeDataType.Numeric),
        new JdeField("FESUFUUPMT", "FESUFUUPMT", JdeDataType.Numeric),
        new JdeField("FEUSER", "FEUSER", JdeDataType.String, 20),
        new JdeField("FEUPMJ", "FEUPMJ", JdeDataType.Numeric),
        new JdeField("FEJOBN", "FEJOBN", JdeDataType.String, 20),
        new JdeField("FEUPMT", "FEUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F96412_0", "Primary Key on FESUTYPE, FEHOSTTYPE, FESUFILETY, FEESUP", new[] { "FESUTYPE", "FEHOSTTYPE", "FESUFILETY", "FEESUP" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F96412_2", "Index on FEESUP", new[] { "FEESUP" })
    };
}
