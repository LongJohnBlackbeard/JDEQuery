using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74Y063 - .
/// </summary>
public class F74Y063 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ECUKID.
        /// </summary>
        public const string ECUKID = "ECUKID";

        /// <summary>
        /// ECY74FILP.
        /// </summary>
        public const string ECY74FILP = "ECY74FILP";

        /// <summary>
        /// ECCO.
        /// </summary>
        public const string ECCO = "ECCO";

        /// <summary>
        /// ECY74FDT.
        /// </summary>
        public const string ECY74FDT = "ECY74FDT";

        /// <summary>
        /// ECY74TDT.
        /// </summary>
        public const string ECY74TDT = "ECY74TDT";

        /// <summary>
        /// ECY74GDT.
        /// </summary>
        public const string ECY74GDT = "ECY74GDT";

        /// <summary>
        /// ECY74TT.
        /// </summary>
        public const string ECY74TT = "ECY74TT";

        /// <summary>
        /// ECY74EST.
        /// </summary>
        public const string ECY74EST = "ECY74EST";

        /// <summary>
        /// ECY74CTX.
        /// </summary>
        public const string ECY74CTX = "ECY74CTX";

        /// <summary>
        /// ECY74FILE.
        /// </summary>
        public const string ECY74FILE = "ECY74FILE";

        /// <summary>
        /// ECY74FILC.
        /// </summary>
        public const string ECY74FILC = "ECY74FILC";

        /// <summary>
        /// ECUSER.
        /// </summary>
        public const string ECUSER = "ECUSER";

        /// <summary>
        /// ECPID.
        /// </summary>
        public const string ECPID = "ECPID";

        /// <summary>
        /// ECJOBN.
        /// </summary>
        public const string ECJOBN = "ECJOBN";

        /// <summary>
        /// ECUPMJ.
        /// </summary>
        public const string ECUPMJ = "ECUPMJ";

        /// <summary>
        /// ECUPMT.
        /// </summary>
        public const string ECUPMT = "ECUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F74Y063";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ECUKID", "ECUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("ECY74FILP", "ECY74FILP", JdeDataType.String, 20),
        new JdeField("ECCO", "ECCO", JdeDataType.String, 10),
        new JdeField("ECY74FDT", "ECY74FDT", JdeDataType.Numeric),
        new JdeField("ECY74TDT", "ECY74TDT", JdeDataType.Numeric),
        new JdeField("ECY74GDT", "ECY74GDT", JdeDataType.Numeric),
        new JdeField("ECY74TT", "ECY74TT", JdeDataType.String, 30),
        new JdeField("ECY74EST", "ECY74EST", JdeDataType.String, 30),
        new JdeField("ECY74CTX", "ECY74CTX", JdeDataType.String, 60),
        new JdeField("ECY74FILE", "ECY74FILE", JdeDataType.String, 36),
        new JdeField("ECY74FILC", "ECY74FILC", JdeDataType.String, 36),
        new JdeField("ECUSER", "ECUSER", JdeDataType.String, 20),
        new JdeField("ECPID", "ECPID", JdeDataType.String, 20),
        new JdeField("ECJOBN", "ECJOBN", JdeDataType.String, 20),
        new JdeField("ECUPMJ", "ECUPMJ", JdeDataType.Numeric),
        new JdeField("ECUPMT", "ECUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74Y063_0", "Primary Key on ECUKID", new[] { "ECUKID" }, isUnique: true, isPrimaryKey: true)
    };
}
