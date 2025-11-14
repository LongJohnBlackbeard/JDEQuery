using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F17113 - .
/// </summary>
public class F17113 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ADITYPE.
        /// </summary>
        public const string ADITYPE = "ADITYPE";

        /// <summary>
        /// ADAN8DL.
        /// </summary>
        public const string ADAN8DL = "ADAN8DL";

        /// <summary>
        /// ADCTR.
        /// </summary>
        public const string ADCTR = "ADCTR";

        /// <summary>
        /// ADMMCU.
        /// </summary>
        public const string ADMMCU = "ADMMCU";

        /// <summary>
        /// ADITM.
        /// </summary>
        public const string ADITM = "ADITM";

        /// <summary>
        /// ADPRODM.
        /// </summary>
        public const string ADPRODM = "ADPRODM";

        /// <summary>
        /// ADPRODF.
        /// </summary>
        public const string ADPRODF = "ADPRODF";

        /// <summary>
        /// ADAN8AS.
        /// </summary>
        public const string ADAN8AS = "ADAN8AS";

        /// <summary>
        /// ADUSER.
        /// </summary>
        public const string ADUSER = "ADUSER";

        /// <summary>
        /// ADPID.
        /// </summary>
        public const string ADPID = "ADPID";

        /// <summary>
        /// ADUPMJ.
        /// </summary>
        public const string ADUPMJ = "ADUPMJ";

        /// <summary>
        /// ADUPMT.
        /// </summary>
        public const string ADUPMT = "ADUPMT";

        /// <summary>
        /// ADJOBN.
        /// </summary>
        public const string ADJOBN = "ADJOBN";

        /// <summary>
        /// ADDCTO.
        /// </summary>
        public const string ADDCTO = "ADDCTO";

        /// <summary>
        /// ADTYPS.
        /// </summary>
        public const string ADTYPS = "ADTYPS";
    }

    /// <inheritdoc />
    public override string TableName => "F17113";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ADITYPE", "ADITYPE", JdeDataType.String, 2, true, true),
        new JdeField("ADAN8DL", "ADAN8DL", JdeDataType.Numeric, null, true, true),
        new JdeField("ADCTR", "ADCTR", JdeDataType.String, 6, true, true),
        new JdeField("ADMMCU", "ADMMCU", JdeDataType.String, 24, true, true),
        new JdeField("ADITM", "ADITM", JdeDataType.Numeric, null, true, true),
        new JdeField("ADPRODM", "ADPRODM", JdeDataType.String, 16, true, true),
        new JdeField("ADPRODF", "ADPRODF", JdeDataType.String, 16, true, true),
        new JdeField("ADAN8AS", "ADAN8AS", JdeDataType.Numeric),
        new JdeField("ADUSER", "ADUSER", JdeDataType.String, 20),
        new JdeField("ADPID", "ADPID", JdeDataType.String, 20),
        new JdeField("ADUPMJ", "ADUPMJ", JdeDataType.Numeric),
        new JdeField("ADUPMT", "ADUPMT", JdeDataType.Numeric),
        new JdeField("ADJOBN", "ADJOBN", JdeDataType.String, 20),
        new JdeField("ADDCTO", "ADDCTO", JdeDataType.String, 4, true, true),
        new JdeField("ADTYPS", "ADTYPS", JdeDataType.String, 2, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F17113_0", "Primary Key on ADITYPE, ADAN8DL, ADCTR, ADMMCU, ADITM, ADPRODM, ADPRODF, ADDCTO, ADTYPS", new[] { "ADITYPE", "ADAN8DL", "ADCTR", "ADMMCU", "ADITM", "ADPRODM", "ADPRODF", "ADDCTO", "ADTYPS" }, isUnique: true, isPrimaryKey: true)
    };
}
