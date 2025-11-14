using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1523 - .
/// </summary>
public class F1523 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// OGLGNM.
        /// </summary>
        public const string OGLGNM = "OGLGNM";

        /// <summary>
        /// OGLGLV.
        /// </summary>
        public const string OGLGLV = "OGLGLV";

        /// <summary>
        /// OGLGCL.
        /// </summary>
        public const string OGLGCL = "OGLGCL";

        /// <summary>
        /// OGAMID.
        /// </summary>
        public const string OGAMID = "OGAMID";

        /// <summary>
        /// OGDL01.
        /// </summary>
        public const string OGDL01 = "OGDL01";

        /// <summary>
        /// OGEXR.
        /// </summary>
        public const string OGEXR = "OGEXR";

        /// <summary>
        /// OGEPCD.
        /// </summary>
        public const string OGEPCD = "OGEPCD";

        /// <summary>
        /// OGRO01.
        /// </summary>
        public const string OGRO01 = "OGRO01";

        /// <summary>
        /// OGRO02.
        /// </summary>
        public const string OGRO02 = "OGRO02";

        /// <summary>
        /// OGUM.
        /// </summary>
        public const string OGUM = "OGUM";

        /// <summary>
        /// OGRQ.
        /// </summary>
        public const string OGRQ = "OGRQ";

        /// <summary>
        /// OGLSET.
        /// </summary>
        public const string OGLSET = "OGLSET";

        /// <summary>
        /// OGSTYL.
        /// </summary>
        public const string OGSTYL = "OGSTYL";

        /// <summary>
        /// OGUTTY.
        /// </summary>
        public const string OGUTTY = "OGUTTY";

        /// <summary>
        /// OGFOTY.
        /// </summary>
        public const string OGFOTY = "OGFOTY";

        /// <summary>
        /// OGARGC.
        /// </summary>
        public const string OGARGC = "OGARGC";

        /// <summary>
        /// OGURCD.
        /// </summary>
        public const string OGURCD = "OGURCD";

        /// <summary>
        /// OGURDT.
        /// </summary>
        public const string OGURDT = "OGURDT";

        /// <summary>
        /// OGURAT.
        /// </summary>
        public const string OGURAT = "OGURAT";

        /// <summary>
        /// OGURAB.
        /// </summary>
        public const string OGURAB = "OGURAB";

        /// <summary>
        /// OGURRF.
        /// </summary>
        public const string OGURRF = "OGURRF";

        /// <summary>
        /// OGUSER.
        /// </summary>
        public const string OGUSER = "OGUSER";

        /// <summary>
        /// OGPID.
        /// </summary>
        public const string OGPID = "OGPID";

        /// <summary>
        /// OGUPMJ.
        /// </summary>
        public const string OGUPMJ = "OGUPMJ";

        /// <summary>
        /// OGUPMT.
        /// </summary>
        public const string OGUPMT = "OGUPMT";

        /// <summary>
        /// OGJOBN.
        /// </summary>
        public const string OGJOBN = "OGJOBN";

        /// <summary>
        /// OGTORG.
        /// </summary>
        public const string OGTORG = "OGTORG";

        /// <summary>
        /// OGENTJ.
        /// </summary>
        public const string OGENTJ = "OGENTJ";
    }

    /// <inheritdoc />
    public override string TableName => "F1523";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("OGLGNM", "OGLGNM", JdeDataType.Numeric, null, true, true),
        new JdeField("OGLGLV", "OGLGLV", JdeDataType.String, 2),
        new JdeField("OGLGCL", "OGLGCL", JdeDataType.String, 4),
        new JdeField("OGAMID", "OGAMID", JdeDataType.String, 8),
        new JdeField("OGDL01", "OGDL01", JdeDataType.String, 60),
        new JdeField("OGEXR", "OGEXR", JdeDataType.String, 60),
        new JdeField("OGEPCD", "OGEPCD", JdeDataType.String, 4),
        new JdeField("OGRO01", "OGRO01", JdeDataType.String, 6),
        new JdeField("OGRO02", "OGRO02", JdeDataType.String, 6),
        new JdeField("OGUM", "OGUM", JdeDataType.String, 4),
        new JdeField("OGRQ", "OGRQ", JdeDataType.String, 2),
        new JdeField("OGLSET", "OGLSET", JdeDataType.String, 4),
        new JdeField("OGSTYL", "OGSTYL", JdeDataType.String, 4),
        new JdeField("OGUTTY", "OGUTTY", JdeDataType.String, 10),
        new JdeField("OGFOTY", "OGFOTY", JdeDataType.String, 10),
        new JdeField("OGARGC", "OGARGC", JdeDataType.String, 8),
        new JdeField("OGURCD", "OGURCD", JdeDataType.String, 4),
        new JdeField("OGURDT", "OGURDT", JdeDataType.Numeric),
        new JdeField("OGURAT", "OGURAT", JdeDataType.Numeric),
        new JdeField("OGURAB", "OGURAB", JdeDataType.Numeric),
        new JdeField("OGURRF", "OGURRF", JdeDataType.String, 30),
        new JdeField("OGUSER", "OGUSER", JdeDataType.String, 20),
        new JdeField("OGPID", "OGPID", JdeDataType.String, 20),
        new JdeField("OGUPMJ", "OGUPMJ", JdeDataType.Numeric),
        new JdeField("OGUPMT", "OGUPMT", JdeDataType.Numeric),
        new JdeField("OGJOBN", "OGJOBN", JdeDataType.String, 20),
        new JdeField("OGTORG", "OGTORG", JdeDataType.String, 20),
        new JdeField("OGENTJ", "OGENTJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1523_0", "Primary Key on OGLGNM", new[] { "OGLGNM" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F1523_2", "Index on OGSTYL, OGARGC, OGUTTY, OGLSET", new[] { "OGSTYL", "OGARGC", "OGUTTY", "OGLSET" })
    };
}
