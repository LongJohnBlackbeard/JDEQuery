using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0116D - .
/// </summary>
public class F0116D : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// AAAN8.
        /// </summary>
        public const string AAAN8 = "AAAN8";

        /// <summary>
        /// AALNGP.
        /// </summary>
        public const string AALNGP = "AALNGP";

        /// <summary>
        /// AAEFTB.
        /// </summary>
        public const string AAEFTB = "AAEFTB";

        /// <summary>
        /// AAEFTF.
        /// </summary>
        public const string AAEFTF = "AAEFTF";

        /// <summary>
        /// AAADD1.
        /// </summary>
        public const string AAADD1 = "AAADD1";

        /// <summary>
        /// AAADD2.
        /// </summary>
        public const string AAADD2 = "AAADD2";

        /// <summary>
        /// AAADD3.
        /// </summary>
        public const string AAADD3 = "AAADD3";

        /// <summary>
        /// AAADD4.
        /// </summary>
        public const string AAADD4 = "AAADD4";

        /// <summary>
        /// AACTY1.
        /// </summary>
        public const string AACTY1 = "AACTY1";

        /// <summary>
        /// AAADDS.
        /// </summary>
        public const string AAADDS = "AAADDS";

        /// <summary>
        /// AAADDZ.
        /// </summary>
        public const string AAADDZ = "AAADDZ";

        /// <summary>
        /// AACOUN.
        /// </summary>
        public const string AACOUN = "AACOUN";

        /// <summary>
        /// AAEFTBF.
        /// </summary>
        public const string AAEFTBF = "AAEFTBF";

        /// <summary>
        /// AACTR.
        /// </summary>
        public const string AACTR = "AACTR";

        /// <summary>
        /// AAUPMJ.
        /// </summary>
        public const string AAUPMJ = "AAUPMJ";

        /// <summary>
        /// AAUPMT.
        /// </summary>
        public const string AAUPMT = "AAUPMT";

        /// <summary>
        /// AAJOBN.
        /// </summary>
        public const string AAJOBN = "AAJOBN";

        /// <summary>
        /// AAUSER.
        /// </summary>
        public const string AAUSER = "AAUSER";

        /// <summary>
        /// AAPID.
        /// </summary>
        public const string AAPID = "AAPID";

        /// <summary>
        /// AAADLC1.
        /// </summary>
        public const string AAADLC1 = "AAADLC1";

        /// <summary>
        /// AAADLC2.
        /// </summary>
        public const string AAADLC2 = "AAADLC2";

        /// <summary>
        /// AAADLC3.
        /// </summary>
        public const string AAADLC3 = "AAADLC3";

        /// <summary>
        /// AAADLC4.
        /// </summary>
        public const string AAADLC4 = "AAADLC4";

        /// <summary>
        /// AAADLN.
        /// </summary>
        public const string AAADLN = "AAADLN";

        /// <summary>
        /// AACTYF.
        /// </summary>
        public const string AACTYF = "AACTYF";

        /// <summary>
        /// AAPOCF.
        /// </summary>
        public const string AAPOCF = "AAPOCF";

        /// <summary>
        /// AAFUMATH4.
        /// </summary>
        public const string AAFUMATH4 = "AAFUMATH4";

        /// <summary>
        /// AAFUDATE4.
        /// </summary>
        public const string AAFUDATE4 = "AAFUDATE4";

        /// <summary>
        /// AAFTCHAR4.
        /// </summary>
        public const string AAFTCHAR4 = "AAFTCHAR4";

        /// <summary>
        /// AAFUTUSTR4.
        /// </summary>
        public const string AAFUTUSTR4 = "AAFUTUSTR4";
    }

    /// <inheritdoc />
    public override string TableName => "F0116D";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("AAAN8", "AAAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("AALNGP", "AALNGP", JdeDataType.String, 4, true, true),
        new JdeField("AAEFTB", "AAEFTB", JdeDataType.Numeric, null, true, true),
        new JdeField("AAEFTF", "AAEFTF", JdeDataType.String, 2),
        new JdeField("AAADD1", "AAADD1", JdeDataType.String, 80),
        new JdeField("AAADD2", "AAADD2", JdeDataType.String, 80),
        new JdeField("AAADD3", "AAADD3", JdeDataType.String, 80),
        new JdeField("AAADD4", "AAADD4", JdeDataType.String, 80),
        new JdeField("AACTY1", "AACTY1", JdeDataType.String, 50),
        new JdeField("AAADDS", "AAADDS", JdeDataType.String, 6),
        new JdeField("AAADDZ", "AAADDZ", JdeDataType.String, 24),
        new JdeField("AACOUN", "AACOUN", JdeDataType.String, 50),
        new JdeField("AAEFTBF", "AAEFTBF", JdeDataType.String, 2),
        new JdeField("AACTR", "AACTR", JdeDataType.String, 6),
        new JdeField("AAUPMJ", "AAUPMJ", JdeDataType.Numeric),
        new JdeField("AAUPMT", "AAUPMT", JdeDataType.Numeric),
        new JdeField("AAJOBN", "AAJOBN", JdeDataType.String, 20),
        new JdeField("AAUSER", "AAUSER", JdeDataType.String, 20),
        new JdeField("AAPID", "AAPID", JdeDataType.String, 20),
        new JdeField("AAADLC1", "AAADLC1", JdeDataType.String, 80),
        new JdeField("AAADLC2", "AAADLC2", JdeDataType.String, 80),
        new JdeField("AAADLC3", "AAADLC3", JdeDataType.String, 80),
        new JdeField("AAADLC4", "AAADLC4", JdeDataType.String, 80),
        new JdeField("AAADLN", "AAADLN", JdeDataType.String, 80),
        new JdeField("AACTYF", "AACTYF", JdeDataType.String, 50),
        new JdeField("AAPOCF", "AAPOCF", JdeDataType.String, 24),
        new JdeField("AAFUMATH4", "AAFUMATH4", JdeDataType.Numeric),
        new JdeField("AAFUDATE4", "AAFUDATE4", JdeDataType.Numeric),
        new JdeField("AAFTCHAR4", "AAFTCHAR4", JdeDataType.String, 2),
        new JdeField("AAFUTUSTR4", "AAFUTUSTR4", JdeDataType.String, 80)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0116D_0", "Primary Key on AAAN8, AALNGP, AAEFTB", new[] { "AAAN8", "AALNGP", "AAEFTB" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F0116D_2", "Index on AAAN8, AAEFTB", new[] { "AAAN8", "AAEFTB" }),
        new JdeIndex("F0116D_3", "Index on AAPOCF, AAADLC1, AAADLN, AAEFTBF", new[] { "AAPOCF", "AAADLC1", "AAADLN", "AAEFTBF" })
    };
}
